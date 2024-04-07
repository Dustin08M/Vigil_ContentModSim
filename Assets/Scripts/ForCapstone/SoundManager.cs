using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public Sound[] musicSounds, sfxSounds,footStepSound;
    public AudioSource musicSource, sfxSource,footStepSoundSource;


    //Disabled since I put it in GameManager
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
/*        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GameMenu"))
        {
            //Play menu music
            PlayMusic("MainMenu");
        }*/
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.Name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Sound s = Array.Find(sfxSounds, x => x.Name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.PlayOneShot(s.clip);
            sfxSource.Play();
        }
    }

    public void PlayFootStepSfx()
    {
        if (footStepSound.Length > 0)
        {
            int randomIndex = UnityEngine.Random.Range(0, footStepSound.Length);
            footStepSoundSource.clip = footStepSound[randomIndex].clip;
            footStepSoundSource.Play();
        }
        else
        {
            Debug.Log("Footstep Sounds array is empty");
        }
    }
    public void TimerStopMenuMusic()
    {
        Invoke("StopMenuMusic", 1f);
    }

    void StopMenuMusic()
    {
        musicSource.Pause();
    }
}
