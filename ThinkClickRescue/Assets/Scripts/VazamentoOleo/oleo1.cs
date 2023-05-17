using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oleo1 : MonoBehaviour
{
    public static bool destuiu1;

    bool mouseDentroDoObjeto;
    void Start()
    {
        mouseDentroDoObjeto = false;
        destuiu1 = false;
    }
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
                destuiu1 = true;
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
