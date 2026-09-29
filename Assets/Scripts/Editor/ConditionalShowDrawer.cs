using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ConditionalShowAttribute))]
public class ConditionalShowDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        ConditionalShowAttribute condAttribute = (ConditionalShowAttribute)attribute;

        // Находим зависимое свойство в том же классе
        SerializedProperty sourcePropertyValue = property.serializedObject.FindProperty(condAttribute.ConditionalSourceField);

        // Если истина — рисуем поле, иначе скрываем
        if (sourcePropertyValue != null && sourcePropertyValue.propertyType == SerializedPropertyType.Boolean && sourcePropertyValue.boolValue)
            EditorGUI.PropertyField(position, property, label, true);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        ConditionalShowAttribute condAttribute = (ConditionalShowAttribute)attribute;
        SerializedProperty sourcePropertyValue = property.serializedObject.FindProperty(condAttribute.ConditionalSourceField);

        // Если поле скрыто, возвращаем высоту 0, чтобы не было пустых отступов
        if (sourcePropertyValue != null && sourcePropertyValue.propertyType == SerializedPropertyType.Boolean && !sourcePropertyValue.boolValue)
            return 0f;

        return base.GetPropertyHeight(property, label);
    }
}

