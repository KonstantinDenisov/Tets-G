using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour
{
    [SerializeField] private int _cost;

    public int Cost
    {
        get => _cost;
        set => _cost = value;
    }
}
