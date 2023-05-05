using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pegagarrafas : MonoBehaviour
{
    private bool win;
     
    public GameObject vitoria;
    public GameObject camerapos;
    public AudioSource audio;
    public int ContatGarrafas;

    

    private void Start()
    {
       
        win = false;
       
    }

    private void Update()
    {
       
        WinLoseGame();
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "garrafa")
        {
            Destroy(c.gameObject);
            ContatGarrafas++;

        }
        
        if(ContatGarrafas == 3)
        {
          win = true;    
        }
        
    }

    private void WinLoseGame()
    {
        if(win == true)
        {
            vitoria.SetActive(true);
            audio.mute = true;
            Time.timeScale = 0;
        }


    }
}
