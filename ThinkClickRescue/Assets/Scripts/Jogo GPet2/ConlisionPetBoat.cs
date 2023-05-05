using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConlisionPetBoat : MonoBehaviour
{

    public int garrafas;
    public bool ColetouTodas;
    public TextMesh garrafasColetadas;
    public bool win;
    public GameObject vitoria;

    // Start is called before the first frame update
    void Start()
    {
        win = false;
    }

    // Update is called once per frame
    void Update()
    {
        WinLoseGame();
    }

    private void WinLoseGame()
    {
        if (win == true) 
        {
            vitoria.SetActive(true);
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "GPet")
        {
            Destroy(collision.gameObject);
            garrafas++;

        }

        if (garrafas == 4)
        {
            win = true;
        }
    }
}
