using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubo2 : MonoBehaviour
{
    public static bool destuiu2;

    bool mouseDentroDoObjeto;
    void Start()
    {
        mouseDentroDoObjeto = false;
        destuiu2 = false;
    }
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
                destuiu2 = true;
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
