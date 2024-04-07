using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAlarm : MonoBehaviour
{
    RIngAlarmScript[] ringAlarms;
    private void Start()
    {
        ringAlarms = FindObjectsOfType<RIngAlarmScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (RIngAlarmScript alarms in ringAlarms)
            {
                alarms.hasTriggeredAlarm = true;
            }
            Invoke("DisableThisShit",3f);
        }
    }

    void DisableThisShit()
    {
        this.gameObject.SetActive(false);
    }
}
