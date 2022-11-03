using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegagarrafas : MonoBehaviour
{
    public float speedWin;
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
            panel.transform.position = Vector2.MoveTowards(panel.transform.position, camerapos.transform.position, speedWin * Time.deltaTime);
        }

        if (Timer.AcabaTempo == true)         
        {
            
            panel2.transform.position = Vector2.MoveTowards(panel2.transform.position, camerapos.transform.position, speedWin * Time.deltaTime);
        }

    }
}
