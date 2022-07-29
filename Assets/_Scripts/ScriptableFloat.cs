using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableFloat : ScriptableObject
{
    [SerializeField] private float value;

    public float Value
    {
        get => value;
        set => this.value = value;
    }
}
