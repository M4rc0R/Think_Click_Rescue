using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// script de movimentos e velocidade do jogador
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;
    private Animator anim;

    public string venci;
    public string perdi;

    private bool win;
    private bool loser;

    

    private float dirX = 0f;
    private float dirY = 0f;
    [SerializeField] private float moveSpeed = 7f; // velocidade do jogador

    private enum MovementState { idle, running }


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();

        loser = false;
        win = false;
    }

    // Update is called once per frame
    private void Update() // movimentos do jogador (setas ou WASD)
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        //rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        dirY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, dirY * moveSpeed);
        // rb.velocity = new Vector2(dirY * moveSpeed, rb.velocity.x);


        


        UpdateAnimationState();
        WinLoseGame();

        

    }

    private void UpdateAnimationState() //fazer o sprite mudar de direção e possivel adição de animações separadas
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        anim.SetInteger("state", (int)state);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("pontoB") == true)
        {
            win = true;

        }
    }


    private void WinLoseGame()
    {
        if (win == true)
        {
            Timer.AcabaTempo = false;
            Timer.ParaTempo = true;
            SceneManager.LoadScene(venci);
        }

        if (loser == true || Timer.AcabaTempo == true)
        {
            Timer.ParaTempo = true;
            SceneManager.LoadScene(perdi);
        }

    }

}
