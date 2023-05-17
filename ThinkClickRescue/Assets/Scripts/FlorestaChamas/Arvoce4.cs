using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arvoce4 : MonoBehaviour
{
    public static bool destuiu4;

    bool mouseDentroDoObjeto;
    void Start()
    {
        mouseDentroDoObjeto = false;
        destuiu4 = false;
    }
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
                destuiu4 = true;
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
