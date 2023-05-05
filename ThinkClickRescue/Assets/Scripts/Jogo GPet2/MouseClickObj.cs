using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseClickObj : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private RectTransform _transform;
    private CanvasGroup canvasGroup;



    private void Awake()
    {
        _transform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Inicio Drag!");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Fim Drag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        _transform.anchoredPosition += eventData.delta / canvas.scaleFactor; 
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Apertou!");
    }

    
}