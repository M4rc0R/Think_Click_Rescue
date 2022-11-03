using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speedWin;
    private bool win;
    private bool loser;

    public Animator animator;
    public float speed;

    public GameObject panel;
    public GameObject panel2;

    public GameObject camerapos;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        win = false;
        loser = false;
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);

        transform.position = transform.position + movement * speed * Time.deltaTime;

        WinLoseGame();

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("pontoB") == true)
        {
            win = true;
            
        }
        if (col.CompareTag("pontoA")) 
        {
            loser = true;
            
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

        if (loser == true || Timer.AcabaTempo == true)         
        {
            Timer.ParaTempo = true;
            panel2.transform.position = Vector2.MoveTowards(panel2.transform.position, camerapos.transform.position, speedWin * Time.deltaTime);
        }

    }


}
