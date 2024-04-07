using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    [SerializeField] private AudioSource BgMusic;

    private void Start()
    {
        BgMusic.Play();
    }

    
    public void TimerPauseMenuBGMusic()
    {
        Invoke("PauseMenuMusic", 1f);
    }
    void PauseMenuMusic()
    {
        BgMusic.Stop();
    }
}
