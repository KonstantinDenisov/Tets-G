using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
   [SerializeField] private Item _item;
   [SerializeField] private string _label;
   [SerializeField] private int _int;
   

   private void Start()
   {
      _int = 10;
      _label = Convert.ToString(_int);
   }
}
