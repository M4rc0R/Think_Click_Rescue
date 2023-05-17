using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvore3 : MonoBehaviour
{
    public static bool destuiu3;

    bool mouseDentroDoObjeto;
    void Start()
    {
        mouseDentroDoObjeto = false;
        destuiu3 = false;
    }
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
                destuiu3 = true;
            }
        }
    }
    void OnMouseEnter()
    {
        mouseDentroDoObjeto = true;
    }
    void OnMouseExit()
    {
        mouseDentroDoObjeto = false;
    }
}
