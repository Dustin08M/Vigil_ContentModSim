using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RIngAlarmScript : MonoBehaviour
{
    public bool hasTriggeredAlarm;
    bool hasAlreadyPlayed;
    float Timer;
    AudioSource clip;
    public AudioClip AlarmSound;

    private void Start()
    {
        clip = GetComponent<AudioSource>();
        Timer = Random.Range(0, 0.5f);
    }

    private void Update()
    {
        if (hasTriggeredAlarm && !hasAlreadyPlayed)
        {
            Invoke("ActivateAlarm", Timer);
            hasAlreadyPlayed = true;
        }
    }

    void ActivateAlarm()
    {
        clip.PlayOneShot(AlarmSound);
    }
}
