using System;

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public class ClassInfoAttribute : Attribute
{
    public string Description { get; }
    public ClassInfoAttribute(string description) => Description = description;
}

