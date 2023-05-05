using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMeni : MonoBehaviour
{

    public GameObject Enunciado;


    private void Start()
    {

        Time.timeScale = 0;
    }


    public void InicioGame() 
    {
        Enunciado.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void EnunciadoGame() 
    {
        Enunciado.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
