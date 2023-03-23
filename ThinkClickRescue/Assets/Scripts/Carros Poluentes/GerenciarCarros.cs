using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GerenciarCarros : MonoBehaviour
{

    public bool temFumaca;
    public GameObject fumaca;
    public GameObject derrota;
    public GameObject vitoria;
    public Image timer_foreground_image;
    float time_remaining;
    public float max_time;

    // Start is called before the first frame update
    void Start()
    {
        time_remaining = max_time;
        temFumaca = true;
        fumaca  = GameObject.FindGameObjectWithTag("FumacaPoluente");
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



        if (fumaca == null) 
        {

            temFumaca = false;
            vitoria.SetActive(true);
        
        }
    }
}
