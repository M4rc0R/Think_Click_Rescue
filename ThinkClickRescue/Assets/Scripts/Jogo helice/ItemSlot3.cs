using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot3 : MonoBehaviour, IDropHandler
{
    public static bool conectado3;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop3");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            conectado3 = true;

        }
    }
}
