using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TerminalScript : MonoBehaviour //This GameObj is currently attached to: 'PlayerToCameraDistance'
{
    [Header("For Canvas Switching")]
    [SerializeField] private GameObject LQCameraCanvas;
    [SerializeField] private GameObject TerminalCanvas;
    [SerializeField] private GameObject TerminalCamera;


    [Space(10)]
    [Header("Boot Up Screen")]
    [SerializeField] private GameObject BG_For_BootUpVid;
    [SerializeField] private GameObject BootUpVid;
    [SerializeField] private GameObject BootVideoPlayer;

    [Space(10)]
    [Header("For Camera Terminal and Switch Post Processing")]
    [SerializeField] private GameObject CameraZoomTerminal;
    [SerializeField] private GameObject _TerminalPostProcess;
    [SerializeField] private GameObject _PlayerPostProcess;

    [Space(10)]
    [Header("Splash Screen")]
    [SerializeField] private GameObject SplashScreen;

    public void StartBootSequence()
    {
        //CameraZoomTerminal.SetActive(false);
        Invoke("PlayBootUpScreen", 2f);
    }

    void PlayBootUpScreen()
    {
        TerminalCamera.SetActive(true);

        LQCameraCanvas.SetActive(false);
        TerminalCanvas.SetActive(true);

        _TerminalPostProcess.SetActive(true);
        _PlayerPostProcess.SetActive(false);

        BootUpVid.SetActive(true);
        BG_For_BootUpVid.SetActive(true);
        BootVideoPlayer.SetActive(true);
        GameManager CheckBoot = FindObjectOfType<GameManager>();
        if (CheckBoot.HasAlreadyBooted)
        {
            MoveToTerminal bootStatus = FindObjectOfType<MoveToTerminal>();
            bootStatus.HasPlayerBooted = true;

            BG_For_BootUpVid.SetActive(false);
            BootUpVid.SetActive(false);
            BootVideoPlayer.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (!CheckBoot.HasAlreadyBooted)
        {
            Invoke("StartWelcomeSplashScreen", 20);
        }
        CheckBoot.HasAlreadyBooted = true;
    }
    
    void StartWelcomeSplashScreen()
    {
        MoveToTerminal bootStatus = FindObjectOfType<MoveToTerminal>();
        bootStatus.HasPlayerBooted = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        BG_For_BootUpVid.SetActive(false);
        BootUpVid.SetActive(false);
        BootVideoPlayer.SetActive(false);
        SplashScreen.SetActive(true);
        Destroy(SplashScreen, 5f);
    }
}
