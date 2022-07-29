using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Health : MonoBehaviour
{
    [SerializeField] private ScriptableFloat hp;
    [SerializeField] private Text hpValue;

    public void UpdateUI()
    {
        hpValue.text = $"{hp.Value}";
    }
}
