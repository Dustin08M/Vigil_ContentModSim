using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TerminalLogin : MonoBehaviour
{
    [SerializeField] private GameObject LoginPage;
    [SerializeField] private TMP_InputField Email;
    [SerializeField] private TMP_InputField Password;

    [SerializeField] private TMP_Text ErrorTextDisp;

    [SerializeField] private string Origin_email = "17171883";
    [SerializeField] private string Origin_password = "VirtuNet1883";

    [SerializeField] private GameObject VirtuFilter;

    //Check if Player has logged in from Day0
    GameManager CheckLoginStatus;

    private void Start()
    {

    }

    public void LoginAccount()
    {
        LoginPage.SetActive(true);
    }

    public void LoadToMainVirtuFilterUI()
    {
        CheckLoginStatus = FindObjectOfType<GameManager>();
        if (CheckLoginStatus.HasAlreadyLoggedIn)
        {
            VirtuFilter.SetActive(true);
        }
        else
        {
            LoginAccount();
        }
    }
    public void CheckLogin()
    {
        //Incorrect Login & Password
        if (Email.text == Origin_email && Password.text == null && !CheckLoginStatus.HasAlreadyLoggedIn)
            ErrorTextDisp.text = "Please Enter your Password".ToString();

        if (Password.text == Origin_password && Email.text == null && !CheckLoginStatus.HasAlreadyLoggedIn)
            ErrorTextDisp.text = "Error Password".ToString();

        if (Email.text == Origin_email && Password.text != Origin_password && !CheckLoginStatus.HasAlreadyLoggedIn)
            ErrorTextDisp.text = "Passwords do not match, try again.".ToString();

        if (Email.text != Origin_email && Password.text != Origin_password && !CheckLoginStatus.HasAlreadyLoggedIn)
            ErrorTextDisp.text = "Error Login".ToString();

        if (Email.text == Origin_email && Password.text == Origin_password && !CheckLoginStatus.HasAlreadyLoggedIn)
        {
            LoginPage.SetActive(false);
            CheckLoginStatus.HasAlreadyLoggedIn = true;
            Invoke("LoadToMainVirtuFilterUI", 3f);
        }

    }
}
