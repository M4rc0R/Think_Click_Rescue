using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pegagarrafas : MonoBehaviour
{
    public string venci;
    public string perdi;
    private bool win;
    private bool loser;

    public GameObject panel;
    public GameObject panel2;

    public GameObject camerapos;
    public int ContatGarrafas;

    private void Start()
    {
        win = false;
        loser = false;
    }

    private void Update()
    {
        if(Timer.AcabaTempo == true)
        {
            loser = true;
        }
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
            Timer.AcabaTempo = false;
            Timer.ParaTempo = true;
            SceneManager.LoadScene(venci);
        }

        if (Timer.AcabaTempo == true)         
        {

            SceneManager.LoadScene(perdi);
        }

    }
}
