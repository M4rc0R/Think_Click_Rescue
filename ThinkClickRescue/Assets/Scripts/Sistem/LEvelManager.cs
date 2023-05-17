using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LEvelManager : MonoBehaviour
{
    public Button[] botoes;
    int unlockLevelsNumber;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("levelsUnlocked")) 
        {
            PlayerPrefs.SetInt("levelsUnlocked", 1);
        }

        unlockLevelsNumber = PlayerPrefs.GetInt("levelsUnlocked");

        for (int i = 0; i < botoes.Length; i++) 
        {
            botoes[i].interactable = false;
        }
    }

    private void Update()
    {
        unlockLevelsNumber = PlayerPrefs.GetInt("levelsUnlocked");

        for (int i = 0; i < unlockLevelsNumber; i++) 
        {
            botoes[i].interactable = true;
        }
    }




   public void callLevels() 
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("faseAtual") + 1);
    }


}
