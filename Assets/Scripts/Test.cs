using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    [ColoredLabel(153, 50, 204)]
    private int coloredLabelVariable;

    [SerializeField]
    private float normalField;

    public bool showFields;

    [SerializeField]
    [ConditionalShow("showFields")]
    private string hideable1;

    [SerializeField]
    [ConditionalShow("showFields")]
    private int hideable2;
}
