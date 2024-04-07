using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;
public class CheckPlayerSave : MonoBehaviour
{
    [SerializeField] private GameObject loadGameObj;
    GameManager _gameManager;
    SavePlayerData loadSave;
    // Start is called before the first frame update
    private void Awake()
    {
        if (File.Exists("VigilPlayerFile.json"))
        {
            Debug.Log("Player Save File Detected");
            loadGameObj.SetActive(true);
        }
        else
        {
            Debug.Log("No Save File Detected");
            loadGameObj.SetActive(false);
        }
    }
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        loadSave = FindObjectOfType<SavePlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneOnButtonClick()
    {
        loadSave.LoadPlayerDataStats();
        _gameManager.HasPlayerLoadedSave = true;
        SceneManager.LoadScene(_gameManager.LastSceneProgress);
    }

    public void StartNewGameonClick()
    {
        StartCoroutine(newGameStart());
    }

    IEnumerator newGameStart()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync("PrologueCutscene");
    }
    public void _GotoCreditsSceneTimer()
    {
        Invoke("GoToCreditsScene", 2f);
    }
    void GoToCreditsScene()
    {
        SceneManager.LoadSceneAsync("Credits Scene");
    }

    public void QuitThisFuckingGame()
    {
        Application.Quit();
    }
}
