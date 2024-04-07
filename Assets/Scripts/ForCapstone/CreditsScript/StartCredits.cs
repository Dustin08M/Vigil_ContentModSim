using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCredits : MonoBehaviour
{
    [SerializeField] private Animator cameraAnimate;

    private void Awake()
    {
        cameraAnimate.GetComponent<Animator>();
    }
    private void Start()
    {
        DoCameraCredits();
    }

    public void DoCameraCredits()
    {
        cameraAnimate.SetTrigger("DoCredits");
    }
}
