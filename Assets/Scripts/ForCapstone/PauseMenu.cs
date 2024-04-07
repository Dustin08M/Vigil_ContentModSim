using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenuObj;
    public static bool isPaused;
    GameObject player;
    // Update is called once per frame

    void Start()
    {
        _pauseMenuObj.SetActive(false);
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SoundManager.Instance.PlaySFX("OpenPauseMenuSfx");
            if (!isPaused)
                PauseGame();
            else
                ResumeGame();
        }
    }

    public void PauseGame()
    {
        _pauseMenuObj.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        Debug.Log("Paused");
        player.GetComponent<AudioSource>().Pause();
    }

    public void ResumeGame()
    {
        _pauseMenuObj.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Debug.Log("Resume");
        player.GetComponent<AudioSource>().UnPause();
    }
    public void ConfirmBacktoMenu()
    {
        SceneManager.LoadScene("GameMenu");
        Time.timeScale = 1f;
    }
}
