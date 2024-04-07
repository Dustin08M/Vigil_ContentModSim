using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResolutionControl : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    void Start()
    {
        resolutionDropdown.ClearOptions();

        Resolution[] resolutions = Screen.resolutions;

        List<string> options = new List<string>();
        foreach (Resolution res in resolutions)
        {
            string option = res.width + "x" + res.height;
            options.Add(option);
        }

        resolutionDropdown.AddOptions(options);

        resolutionDropdown.value = GetCurrentResolutionIndex(resolutions);
        resolutionDropdown.RefreshShownValue();
    }

    private int GetCurrentResolutionIndex(Resolution[] resolutions)
    {
        Resolution currentResolution = Screen.currentResolution;
        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].width == currentResolution.width &&
                resolutions[i].height == currentResolution.height)
            {
                return i;
            }
        }
        return 0;
    }
    //Apply through button with this shiet
    public void SetResolution(int resolutionIndex)
    {
        Resolution[] resolutions = Screen.resolutions;
        Resolution selectedResolution = resolutions[resolutionIndex];
        Screen.SetResolution(selectedResolution.width, selectedResolution.height, Screen.fullScreen);
    }

    public void ToggleFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Debug.Log("Fullscreen Set: "+isFullscreen);
    }
}
