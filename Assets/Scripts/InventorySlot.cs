using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IDropHandler
{
   public void OnDrop(PointerEventData eventData)
   {
      if (transform.childCount != 0)
         return;
      GameObject dropped = eventData.pointerDrag;
      DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
      draggableItem._parenAfterDrag = transform;
   }
}
