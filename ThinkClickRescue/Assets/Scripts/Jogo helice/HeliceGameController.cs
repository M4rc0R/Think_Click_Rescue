using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliceGameController : MonoBehaviour
{

    public GameObject vitoria;
    public GameObject InGame;
    public bool todosConectados;

    // Update is called once per frame
    void Update()
    {

        if (ItemSlot.conectado == true && ItemSlot2.conectado2 == true && ItemSlot3.conectado3 == true && ItemSlot4.conectado4 == true) 
        {
            todosConectados = true;
            InGame.SetActive(false);
            vitoria.SetActive(true);
        }


    }
}
