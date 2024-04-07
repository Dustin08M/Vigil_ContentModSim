using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViolationFade : MonoBehaviour
{
    public Animator ViolationAnimator;
    void Start()
    {
        ViolationAnimator.GetComponent<Animator>();
    }

    public void TimerViolation()
    {
        Invoke("PlayViolationFade", 0.7f);
    }
    public void PlayViolationFade() //Fades camera to black
    {
        ViolationAnimator.SetTrigger("TR_ViolationFade");
    }
}
