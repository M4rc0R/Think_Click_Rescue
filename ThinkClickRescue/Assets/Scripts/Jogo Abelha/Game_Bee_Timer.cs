using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Bee_Timer : MonoBehaviour
{

    public GameObject derrota;
    public AudioSource audio;
    public Image timer_foreground_image;
    
    float time_remaining;
    public float max_time;


    private void Start()
    {
        time_remaining = max_time;
    }

    private void Update()
    {
        if (time_remaining > 0)
        {
            time_remaining -= Time.deltaTime;
            timer_foreground_image.fillAmount = time_remaining / max_time;

        }
        else 
        {
            derrota.SetActive(true);
            audio.mute = true;
            

        }
       
    }



}
