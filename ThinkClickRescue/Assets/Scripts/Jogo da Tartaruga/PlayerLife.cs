using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public GameObject derrota;
    public AudioSource audio;

    //[SerializeField] private AudioSource deathSoundEffect;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision) //matar o jogador caso ele encostar nos lixos
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die() //reiniciar o jogo
    {
        //deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        derrota.SetActive(true);
        audio.mute = true;
        Time.timeScale = 0;
        //anim.SetTrigger("death");
    }

    /*private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}
