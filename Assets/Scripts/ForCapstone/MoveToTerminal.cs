using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTerminal : MonoBehaviour
{
    public Animator animate;
    CameraSwitch _camSwitch;
    FadeCameraTerminal camFade;
    public bool isModerating;
    public bool canPlayAnimation;

    //This is hooked up to 'TerminalScript.cs'
    //Once splash screen appears, enable it, so in day 1 and so on...
    public bool HasPlayerBooted;

    TerminalScript _BootTerminal;

    private void Start() //This GameObj is currently attached to: 'Camera_Zoom to Terminal UI'
    {
        animate.GetComponent<Animator>();

        //Access these scripts on objs visible in the scene
        _camSwitch = FindObjectOfType<CameraSwitch>();
        camFade = FindObjectOfType<FadeCameraTerminal>();
        _BootTerminal = FindObjectOfType<TerminalScript>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _camSwitch.isInSession && !isModerating)
        {
            _camSwitch.HasPlayerStartBootUp = true;
            MoveCamToPlayerTerminal(); //Zooms in
            camFade.TimerFadeCam(); //Then fades to black
            _camSwitch.BeginSessionText.SetActive(false); //disables the text
            isModerating = true; //sets the value
            StartCoroutine(CallBootPC(2f)); //then calls for the bootup shit
        }
    }
    public void MoveCamToPlayerTerminal()
    {
        animate.SetTrigger("TR_ZoomToPc");
    }
    public void MoveCamTerminalBack()
    {
        animate.SetTrigger("TR_MoveBack");
    }

    IEnumerator CallBootPC(float _timer)
    {
        bool hasBootUp = false;
        if (!hasBootUp)
        {
            _BootTerminal.StartBootSequence();
            hasBootUp = false;
            yield return null;
        }
    }
}
