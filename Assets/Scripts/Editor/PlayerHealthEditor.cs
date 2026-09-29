using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Health), editorForChildClasses: true)]
public class PlayerHealthEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Берем тип класса (PlayerHealth)
        Type type = target.GetType();

        // Проверяем, есть ли у класса атрибут [ClassInfo]
        ClassInfoAttribute info = type.GetCustomAttribute<ClassInfoAttribute>();

        if (info != null)
        {
            // Выводим текст в специальном поле
            EditorGUILayout.HelpBox(info.Description, MessageType.Info);
            GUILayout.Space(10);
        }

        // Рисуем всё остальное
        DrawDefaultInspector();
    }
}

