using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timercontroller : MonoBehaviour
{
    public GameObject vitoria;
    public AudioSource audio;
    public Image timer_foreground_image;
    float time_remaining;
    public float max_time;
    public static bool temtempo;


    private void Start()
    {
        time_remaining = max_time;
        temtempo = true;
    }

    private void Update()
    {
        if(temtempo == true) { 


        if (time_remaining > 0)
        {
            time_remaining -= Time.deltaTime;
            timer_foreground_image.fillAmount = time_remaining / max_time;

        }
        else
        {
            vitoria.SetActive(true);
            temtempo = false;
            audio.mute = true;

        }
        }
    }
}
