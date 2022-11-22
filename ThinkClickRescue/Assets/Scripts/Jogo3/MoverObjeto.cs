using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class MoverObjeto : MonoBehaviour
{
    Vector3 posicaoInicial;
    Vector3 posicaoDestino;
    Vector3 vetorDirecao;

    Rigidbody2D _rigidbody2D;

    bool estaArrastando;
    float distancia;

    [HideInInspector]

    private bool estaConectado;

    [Range (1, 15)]
    public float velocidadeMovimento = 10;

    public Transform conector;

    [Range(0.1f, 2.0f)]
    public float distanciaMiniConector  = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = transform.root.GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 0;
       
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        posicaoInicial = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _rigidbody2D.gravityScale = 1;
        estaArrastando = true;
        estaConectado = false;
        
    }

    void OnMouseDrag()
    {
        posicaoDestino = posicaoInicial + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vetorDirecao = posicaoDestino - transform.root.position;
        _rigidbody2D.velocity = vetorDirecao * velocidadeMovimento;
        
    }



    }

 
