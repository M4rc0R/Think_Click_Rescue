using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{


   public void LoadScene(string nome)
   {
    SceneManager.LoadScene(nome);
   }

   public void ResetGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
