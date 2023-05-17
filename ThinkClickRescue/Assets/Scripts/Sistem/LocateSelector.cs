using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocateSelector : MonoBehaviour
{


    public void Start()
    {
        int ID = PlayerPrefs.GetInt("LocaleKey", 0);
        EcolherLocal(ID);
    }

    private bool active = false;    

    public void EcolherLocal(int _localeID) 
    {
        if (active == true)
            return;
        StartCoroutine(SetLocale(_localeID));
    }

    IEnumerator SetLocale(int _localeID) 
    {
        active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
        PlayerPrefs.SetInt("LocaleKey", _localeID);
        active = false;
    }
}
