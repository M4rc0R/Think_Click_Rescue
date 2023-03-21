using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    private InicioGame enunciado1;

   public void LoadScene(string nome)
   {
    SceneManager.LoadScene(nome);
   }

   public void ResetGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

    public void SairEnunciado(string nome) {

        GameObject Enunciado = GameObject.FindGameObjectWithTag("Enunciado1");
        this.enunciado1 = Enunciado.GetComponent<InicioGame>();
        this.enunciado1.Esconder();
        SceneManager.LoadScene(nome);

    }

   public void NextGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void FecharJogo()
   {
        Debug.Log("Fechou!");
        Application.Quit();
   } 
}
