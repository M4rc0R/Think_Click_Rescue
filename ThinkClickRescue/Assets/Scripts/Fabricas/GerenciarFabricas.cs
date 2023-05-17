using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GerenciarFabricas : MonoBehaviour
{

    public bool temFumaca = true;
    public GameObject fumaca;
    public GameObject derrota;
    public GameObject vitoria;
    public Image timer_foreground_image;
    float time_remaining;
    public float max_time;

    // Start is called before the first frame update
    void Start()
    {

        temFumaca = true;
        time_remaining = max_time;
    }


    void Update()
    {


        if (time_remaining > 0)
        {
            time_remaining -= Time.deltaTime;
            timer_foreground_image.fillAmount = time_remaining / max_time;

        }
        else
        {
            derrota.SetActive(true);

        }



        if (FabricaFumaca1.destuiu == true && FabricaFumaca2.destuiu2 == true && FabricaFumaca3.destuiu3 == true && FabricaFumaca4.destuiu4 == true)
        {
           

            temFumaca = false;
            Time.timeScale = 0;
            vitoria.SetActive(true);

        }
    }
}
