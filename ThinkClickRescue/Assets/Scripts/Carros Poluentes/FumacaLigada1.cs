using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FumacaLigada1 : MonoBehaviour
{

    public static bool destuiu;

    bool mouseDentroDoObjeto;
    void Start()
    {
        mouseDentroDoObjeto = false;
        destuiu = false;
    }
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
                destuiu = true;
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
