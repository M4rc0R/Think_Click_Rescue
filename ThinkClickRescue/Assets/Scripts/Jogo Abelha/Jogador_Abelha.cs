using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jogador_Abelha : MonoBehaviour
{
    
    public bool coletouPolen;
    public int polenColetados;
    public GameObject vitoria;
    public Text pontuacao;
   


    private float velocidadeAbelha = 7f;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Vector2 moveDirection;
    private bool win;

    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        coletouPolen = false;
        polenColetados = 0;
        win = false;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(horizontal, vertical);

        pontuacao.text = "Pólem coletado: " + polenColetados;


        if (polenColetados == 4) 
        {
            coletouPolen = true;
            win = true;
            WinAndLoseCondition();
        }
    }

    private void FixedUpdate()
    {
        Vector3 movePositions = (velocidadeAbelha * Time.deltaTime * moveDirection.normalized) + rb.position;

        rb.MovePosition(movePositions);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "polen") 
        {
            
            polenColetados = polenColetados + 1;
            sr.color = Color.yellow;
        }
    }

    private void WinAndLoseCondition() 
    {
        if (win == true) 
        {
            vitoria.SetActive(true);
            Time.timeScale = 0;
        
        }
    
    }
}
