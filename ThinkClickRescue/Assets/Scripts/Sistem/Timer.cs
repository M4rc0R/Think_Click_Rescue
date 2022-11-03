using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
    

    [SerializeField] private Image uiFill;
    [SerializeField] private Text uiText;

    public float speedWin;

    public int Duration;

    private int remainingDuration;

    public static bool ParaTempo;

    public static bool AcabaTempo;


    private void Start()
    {
        Being(Duration);
        ParaTempo = false;
        AcabaTempo = false;
    }

    private void Being(int Second)
    {
        remainingDuration = Second;
        StartCoroutine(UpdateTimer());
    }

    private IEnumerator UpdateTimer()
    {
        
        while(remainingDuration >= 0 && ParaTempo == false)
        {
            
         uiText.text = $"{remainingDuration / 60:00}:{remainingDuration % 60:00}";
         uiFill.fillAmount = Mathf.InverseLerp(0, Duration, remainingDuration);
         remainingDuration--;
         yield return new WaitForSeconds(1f);
            
        }
        OnEnd();

    }

    private void OnEnd()
    {
        AcabaTempo = true;
    }
}
