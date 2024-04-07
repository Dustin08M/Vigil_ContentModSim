using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetReso : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown;

    private Resolution[] resolutions;

    void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " @" + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height &&
                resolutions[i].refreshRate == Screen.currentResolution.refreshRate)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);

        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void ApplyResolution()
    {
        int selectedResolutionIndex = resolutionDropdown.value;
        Screen.SetResolution(resolutions[selectedResolutionIndex].width,
                             resolutions[selectedResolutionIndex].height,
                             true,
                             resolutions[selectedResolutionIndex].refreshRate);
    }
}
