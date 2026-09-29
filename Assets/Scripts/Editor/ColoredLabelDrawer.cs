using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ColoredLabelAttribute))]
public class ColoredLabelDrawer : PropertyDrawer
{
    private GUIStyle style;
    private Color color;

    public override void OnGUI(
        Rect position,
        SerializedProperty property,
        GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        // Получаем атрибут
        ColoredLabelAttribute coloredAttribute = 
            (ColoredLabelAttribute)attribute;

        // Кэшируем стиль и пересоздаём только при смене цвета
        if (style == null || color != coloredAttribute.LabelColor)
        {
            style = new GUIStyle(EditorStyles.label);
            style.normal.textColor = coloredAttribute.LabelColor;
            style.hover.textColor = coloredAttribute.LabelColor;
            color = coloredAttribute.LabelColor;
        }

        // Добавляем Label с кастомным стилем к полю
        Rect fieldRect = EditorGUI.PrefixLabel(position, label, style);

        // Рисуем поле в этой области
        EditorGUI.PropertyField(fieldRect, property, GUIContent.none);

        EditorGUI.EndProperty();
    }
}

