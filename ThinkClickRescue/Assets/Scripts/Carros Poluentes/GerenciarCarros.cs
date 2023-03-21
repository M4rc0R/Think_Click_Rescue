using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciarCarros : MonoBehaviour
{

    public bool temFumaca;
    public GameObject fumaca;


    // Start is called before the first frame update
    void Start()
    {
        temFumaca = true;
        fumaca  = GameObject.FindGameObjectWithTag("FumacaPoluente");
    }

    // Update is called once per frame
    void Update()
    {
        if (fumaca == null) 
        {

            temFumaca = false;
            SceneManager.LoadScene("Vitória");
        
        }
    }
}
