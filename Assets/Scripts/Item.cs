using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    [SerializeField] private int _cost;
    [SerializeField] private TextMeshProUGUI _label;

    private void Start()
    {
        _label.text = Convert.ToString(_cost);
    }

    public void SetCostLable()
    {
        _label.text = Convert.ToString(_cost);
    }

    public int Cost
    {
        get => _cost;
        set => _cost = value;
    }
}
