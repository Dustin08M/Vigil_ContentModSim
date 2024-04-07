using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ModerationVoteCount : MonoBehaviour
{
    GameManager DayCheck;
    ViolationFade CallAnimation;

    [Header("For Vote Counter")]
    [SerializeField] private TMP_Text ApproveCounter_Text;
    [SerializeField] private TMP_Text RemoveCounter_Text;
    public int CountForApprove = 0;
    public int CountForRemove = 0;

    [Space(10)]
    [Header("For Submit Process UI")]
    [SerializeField] private GameObject PleaseSubmitProcessUI;
    [SerializeField] private GameObject SubmitProcessUI;
    [SerializeField] private GameObject ConfirmedProcess;
    [SerializeField] private GameObject AlreadyConfirmedProcess;
    [SerializeField] private GameObject PlayerUnableToVoteDueToProcess;

    [Space(10)]
    [Header("For Submit Process UI")]
    [SerializeField] private GameObject PlayerViolation;
    [SerializeField] private GameObject FadeScreenViolation;

    //Paired For Game Manager
    public int VoteRequirement;
    public int CurrentVoteCount;

    [Space(10)]
    [Header("Check Before Logging Out")]
    public bool hasSubmitProcess;
    public bool CanLogout;

    private void Start()
    {
        //Refresh current vote count whenever a new scene starts
        CurrentVoteCount = 0;

        DayCheck = FindObjectOfType<GameManager>();
        CallAnimation = FadeScreenViolation.GetComponent<ViolationFade>();
        VoteRequirementPerDay();
        Debug.Log(VoteRequirement);

        //Saves player progress but has to find script within the scene first
        //playerData = FindObjectOfType<SavePlayerData>();
        //Update: this is my old method of saving the player, increment script now handles that save
    }

    private void Update()
    {
        UpdateApproveCounter();
        UpdateRemoveCounter();
    }
    public void UpdateApproveCounter()
    {
        ApproveCounter_Text.text = CountForApprove.ToString();
    }

    public void UpdateRemoveCounter()
    {
        RemoveCounter_Text.text = CountForRemove.ToString();
    }

    public void OpenConfirmProcessUI()
    {
        if (!hasSubmitProcess)
        {
            SubmitProcessUI.SetActive(true);
        }
        else AlreadyConfirmedProcess.SetActive(true);
    }

    public void ShowUnableToVotePost()
    {
        PlayerUnableToVoteDueToProcess.SetActive(true);
    }

    public void ConfirmProcess()
    {
        hasSubmitProcess = true;
        CanLogout = true;
    }

    //Fades to black then goes to next scene
    //If Player has submitted with other pending votes, call for violation
    public void CheckLogOut() 
    {
        if (CanLogout)
        {
            if (CurrentVoteCount != VoteRequirement)
            {
                //!! Count Player Violation !!
                DayCheck.ViolationCount++;

                Debug.Log("*Game Saved*");

                //Call for violation
                //LocksCursor
                PlayerViolation.SetActive(true);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                //Activate UI
                PlayerViolation.SetActive(true);

                //Set it to true first
                FadeScreenViolation.SetActive(true);

                //FadeAnimation wont play unless that gameObj is set to active first (see FadeScreenViolation gameObj)
                CallAnimation.PlayViolationFade();
                //Then Go to Next Day
                Invoke("LoadToNextDayScene", 4f);
            }
            else Debug.Log("Player Has logged out successfully");
            FadeScreenViolation.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            CallAnimation.PlayViolationFade();
            Invoke("LoadToNextDayScene", 4f);
        }
        else PleaseSubmitProcessUI.SetActive(true);
    }
    #region VoteCheckRequireMents
    //Each day has requirements, if it doesnt meet current vote requirement, play violation cutscene
    void VoteRequirementPerDay()
    {
        int CheckDay = DayCheck.CurrentDay;
        switch (CheckDay)
        {
            case 0:
                VoteRequirement = 3;
                break;
            case 1:
                VoteRequirement = 3;
                break;
            case 2:
                VoteRequirement = 4;
                break;
            case 3:
                if (!DayCheck.isDay2_TravisPost1Selected)
                    VoteRequirement = 4;
                else
                    VoteRequirement = 5;
                break;
            case 4:
                if (!DayCheck.isDay1_RiskyNewsSelected)
                    VoteRequirement = 4;
                else
                    VoteRequirement = 5;
                break;
            case 5:
                if (!DayCheck.isDay3_HotdogCultSelected)
                    VoteRequirement = 5;
                else
                    VoteRequirement = 6;
                break;
            case 6:
                VoteRequirement = 6;
                break;
            case 7:
                if (!DayCheck.isDay4_EdwardCaseSelected)
                    VoteRequirement = 5;
                else
                    VoteRequirement = 6;
                break;
            case 8:
                VoteRequirement = 8;
                break;
            case 9:
                VoteRequirement = 8;
                break;

        }

        #region bad condition grammar
        /*if (DayCheck.CurrentDay == 0 || DayCheck.CurrentDay == 1) VoteRequirement = 3;
        if (DayCheck.CurrentDay == 2) VoteRequirement = 4;

        if (DayCheck.CurrentDay == 3 && !DayCheck.isDay2_TravisPost1Selected) VoteRequirement = 4;
        if (DayCheck.CurrentDay == 3 && DayCheck.isDay2_TravisPost1Selected) VoteRequirement = 5;

        if (DayCheck.CurrentDay == 4 && !DayCheck.isDay1_RiskyNewsSelected) VoteRequirement = 4;
        if (DayCheck.CurrentDay == 4 && DayCheck.isDay1_RiskyNewsSelected) VoteRequirement = 5;

        if (DayCheck.CurrentDay == 5 && !DayCheck.isDay3_HotdogCultSelected) VoteRequirement = 5;
        if (DayCheck.CurrentDay == 5 && DayCheck.isDay3_HotdogCultSelected) VoteRequirement = 6;
        if (DayCheck.CurrentDay == 6) VoteRequirement = 6;
        if (DayCheck.CurrentDay == 7 && !DayCheck.isDay4_EdwardCaseSelected) VoteRequirement = 5;
        if (DayCheck.CurrentDay == 7 && DayCheck.isDay4_EdwardCaseSelected) VoteRequirement = 6;
        if (DayCheck.CurrentDay == 8) VoteRequirement = 8;
        if (DayCheck.CurrentDay == 9) VoteRequirement = 8;*/
        #endregion
    }
    void LoadToNextDayScene() //This function is called through in-fucking-voke
    {
        //Example, new player starts at day 0, when it presses and calls this, it should go to day 1
        //Along with Game Manager and its player progression

        if (DayCheck.CurrentDay == 0)
        {
            SceneManager.LoadScene("Day1");
        }

        if (DayCheck.CurrentDay == 1)
        {
            SceneManager.LoadScene("Day2");
        }

        if (DayCheck.CurrentDay == 2)
        {
            SceneManager.LoadScene("Day3");
        }

        if (DayCheck.CurrentDay == 3)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            else
            {
                SceneManager.LoadScene("Day4");
            }
        }

        if (DayCheck.CurrentDay == 4)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            else
            {
                SceneManager.LoadScene("Day5");
            }
        }

        if (DayCheck.CurrentDay == 5)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            else
            {
                SceneManager.LoadScene("Day6");
            }
        }

        if (DayCheck.CurrentDay == 6)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            else
            {
                SceneManager.LoadScene("Day7");
            }
        }

        if (DayCheck.CurrentDay == 7)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            else
            {
                SceneManager.LoadScene("Day8");
            }
        }

        if (DayCheck.CurrentDay == 8)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            else
            {
                SceneManager.LoadScene("Day9");
            }
        }

        if (DayCheck.CurrentDay == 9)
        {
            if (DayCheck.ViolationCount == 4)
            {
                SceneManager.LoadScene("TerminatedEnding");
            }
            if (DayCheck.GoodCounter > DayCheck.BadCounter)
            {
                // Trigger Good Ending
                SceneManager.LoadScene("Good Ending");
            }
            else
            {
                SceneManager.LoadScene("Bad Ending");
            }

            if (DayCheck.GoodCounter > DayCheck.BadCounter
             && !DayCheck.isDay1_RiskyNewsSelected && DayCheck.isDay5_StrugglingFamilySelected &&
             !DayCheck.isDay8_Killer1Selected && !DayCheck.isDay8_Killer2Selected && !DayCheck.isDay8_Killer3Selected && DayCheck.isDay8_PowerPlantSelected &&
             DayCheck.isDay9_KillerLocationSelected & !DayCheck.isDay9_GhostWeaponsSelected)
            {
                SceneManager.LoadScene("True Good Ending");
            }

        }

    }
    #endregion
}
