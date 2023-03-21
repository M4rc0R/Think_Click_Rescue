using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesligandoCarros : MonoBehaviour
{

    bool mouseDentroDoObjeto;
    void Start()
    {
        mouseDentroDoObjeto = false;
    }
    void Update()
    {
        if (mouseDentroDoObjeto == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Destroy(gameObject);
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
