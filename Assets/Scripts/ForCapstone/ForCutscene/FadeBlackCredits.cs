using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeBlackCredits : MonoBehaviour       //This is for credits and disclaimer
{
    [SerializeField] private GameObject FadeOutObj;

    private void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Credits Scene"))
        {
            Invoke("EndofCredits", 102f);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Disclaimer"))
        {
            Invoke("EndOfDisclaimer", 8.2f);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FadeOutObj.SetActive(true);
        }
    }
    void EndofCredits()
    {
        FadeOutObj.SetActive(true);
    }

    void EndOfDisclaimer()
    {
        FadeOutObj.SetActive(true);
    }
}
