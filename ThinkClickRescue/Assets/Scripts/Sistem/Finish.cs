using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//script para chamar proximo level quando jogador tocar o final

public class Finish : MonoBehaviour
{
    //private AudioSource finishSound;

    

    private bool levelCompleted = false;

    /*private void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }*/

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.name == "Tartaruga" && !levelCompleted)
        {
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }    
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
