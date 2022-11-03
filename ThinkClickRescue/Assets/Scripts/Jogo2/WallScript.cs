using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*continuação do script de foguinhos (e arvores)
aqui ele adiciona outros efeitos pros objetos criados, principalmente a  
função de destruir o objeto depois que ele ja saiu da tela do jogador */

public class WallScript : MonoBehaviour
{

    public WallGenerator wallGenerator;


    void Update()
    {
        transform.Translate(Vector2.left * wallGenerator.currentSpeed * Time.deltaTime);
        
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.CompareTag("nextLine"))
        {
            wallGenerator.GenerateNextWallWithGap();
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
