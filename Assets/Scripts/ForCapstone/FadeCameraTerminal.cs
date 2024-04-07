using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCameraTerminal : MonoBehaviour
{
    public Animator FadeAnimator;
    void Start()
    {
        FadeAnimator.GetComponent<Animator>();
        Invoke("FadeBackCam",3.5f);
    }

    public void TimerFadeCam()
    {
        Invoke("FadeCam", 0.7f);
    }
    public void FadeCam() //Fades camera to black
    {
        FadeAnimator.SetTrigger("TR_FadeCam");
    }
    public void FadeBackCam() //Opposite
    {
        FadeAnimator.SetTrigger("TR_FadeBackCam");
    }
}
