using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider MasterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider SfxSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVol"))
        {
            LoadVolume();
        }
        else
        {
            SetMasterVol();
            SetMusicVol();
            SetSfxVol();
        }
    }
    private void Update()
    {
        //Testing on Menu if SoundManager is fking working
        //Error happens if i remove the singleton add parent it to GameManager, it says error instance of an obj
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.Instance.PlaySFX("OpenPauseMenuSfx");
        }*/
    }

    public void SetMasterVol()
    {
        float volume = MasterSlider.value;
        myMixer.SetFloat("MasterVol", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("MasterVol", volume);
    }
    public void SetMusicVol()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("MusicVol", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("MusicVol", volume);
    }
    public void SetSfxVol()
    {
        float volume = SfxSlider.value;
        myMixer.SetFloat("SfxVol", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SfxVol", volume);
    }

    private void LoadVolume()
    {
        MasterSlider.value = PlayerPrefs.GetFloat("MasterVol");
        musicSlider.value = PlayerPrefs.GetFloat("MusicVol");
        SfxSlider.value = PlayerPrefs.GetFloat("SfxVol");
        SetMasterVol();
        SetMusicVol();
        SetSfxVol();
    }
}
