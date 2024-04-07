using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayObjective : MonoBehaviour
{
    [SerializeField] private GameObject ObjText;
    AudioSource playAudio;
    public AudioClip clip;

    private void Start()
    {
        playAudio = GetComponent<AudioSource>();
        Invoke("DisplayObj", 7f);
    }

    void DisplayObj()
    {
        ObjText.SetActive(true);
        Invoke("EndDisplay",7f);
    }

    void EndDisplay()
    {
        ObjText.SetActive(false);
        playAudio.PlayOneShot(clip);
    }
}
