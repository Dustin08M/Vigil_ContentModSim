using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleWindowed : MonoBehaviour
{
    public void ToggleFullscreen(bool fullscreen)
    {
        if (fullscreen) Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
        else Screen.fullScreenMode = FullScreenMode.Windowed;
    }
}
