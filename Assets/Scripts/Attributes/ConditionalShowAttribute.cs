using System;
using UnityEngine;

[AttributeUsage(AttributeTargets.Field)]
public class ConditionalShowAttribute : PropertyAttribute
{
    public string ConditionalSourceField { get; private set; }

    public ConditionalShowAttribute(string conditionalSourceField)
    {
        ConditionalSourceField = conditionalSourceField;
    }
}
