using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IncrementDay : MonoBehaviour
{
    SavePlayerData PlayerSave;
    GameManager _gameManager;
    Scene _getScene;
    private void Awake()
    {
        PlayerSave = FindObjectOfType<SavePlayerData>();
        _gameManager = FindObjectOfType<GameManager>();
        if (!_gameManager.HasPlayerLoadedSave)
        {
            _gameManager.CurrentDay++;
        }
        if (_gameManager.HasPlayerLoadedSave)
        {
            _gameManager.HasPlayerLoadedSave = false;
        }

    }

    void Start()
    {
        _getScene = SceneManager.GetActiveScene();
        _gameManager.LastSceneProgress = _getScene.name;
        PlayerSave.SavePlayerDataStats();
    }
}
