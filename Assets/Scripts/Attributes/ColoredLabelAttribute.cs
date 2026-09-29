using System;
using UnityEngine;

// Указываем, что атрибут можно применять только к полям
[AttributeUsage(AttributeTargets.Field)]
public class ColoredLabelAttribute : PropertyAttribute
{
    public Color LabelColor { get; private set; }

    // Конструктор атрибута, принимающий параметры
    public ColoredLabelAttribute(float r, float g, float b)
    {
        LabelColor = new Color(r/255, g/255, b/255);
    }
}