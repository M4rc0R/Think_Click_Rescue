using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutiondrop;

    Resolution[] resolutions;

    private void Start()
    {
       resolutions =  Screen.resolutions;

        resolutiondrop.ClearOptions();

        List<string> opitions = new List<string>();

        int currentResolutionsIndex = 0;
        for (int i = 0; i < resolutions.Length; i++) 
        {
            string opition = resolutions[i].width + " x " + resolutions[i].height;
            opitions.Add(opition);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) 
            {
                currentResolutionsIndex = i;
            }
        }

        resolutiondrop.AddOptions(opitions);
        resolutiondrop.value = currentResolutionsIndex;
        resolutiondrop.RefreshShownValue();
    }


    public void SetResolution(int resolutionindex) 
    {
        Resolution resolution = resolutions[resolutionindex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


    public void SetVolume(float volume) 
    {
        audioMixer.SetFloat("volume", volume);

    }

    public void SetQuality(int qualityIndex) 
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    
    }

    public void SetFullScreen(bool isFullScreen) 
    {
        Screen.fullScreen = isFullScreen;
    }

}
