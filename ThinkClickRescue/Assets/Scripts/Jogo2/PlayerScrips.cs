using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScrips : MonoBehaviour
{
    public float JumpForce;


    [SerializeField] //saber se o jogador esta no chao e vivo 
    bool isGrounded = false;

    Rigidbody2D RB;

    public string venci;
    public string perdi;
    private bool win;
    private bool loser;

    public void Start()
    {
        win = false;
        loser = false;
    }


    private void Awake() 
    {
        RB = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) //botao de pulo e grounded pra evitar multiplos pulos seguidos
        {
            if(isGrounded == true)
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
        }
        
        WinLoseGame();
    }

    private void OnCollisionEnter2D(Collision2D collision) //troca de valores se tocou o chao
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if(collision.gameObject.CompareTag("wall")) //matar o jogador e reiniciar o level
        {
            
            loser = true;
            
        }

        
    }


    private void WinLoseGame()
    {
        if(win == true || Timer.AcabaTempo == true)
        {
            Timer.AcabaTempo = true;

            SceneManager.LoadScene(venci);
        }

        if (loser == true )         
        {

            SceneManager.LoadScene(perdi);
        }

    }


    
}
