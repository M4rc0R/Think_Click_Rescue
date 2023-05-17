using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public int sceneIndex;

   public void LoadScene(string nome)
   {
    SceneManager.LoadScene(nome);
    Time.timeScale = 1;
    }

    public void OpenScene() 
    {
        SceneManager.LoadScene(sceneIndex);
    }

   public void ResetGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    Time.timeScale = 1;
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
