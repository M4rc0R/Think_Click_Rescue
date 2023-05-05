using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot2 : MonoBehaviour, IDropHandler
{
    public static bool conectado2;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop2");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            conectado2 = true;

        }
    }
}
