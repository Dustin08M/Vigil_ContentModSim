using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserVote : MonoBehaviour
{
    public bool HasPlayerVoted;
    ModerationVoteCount VoteCount;

    [SerializeField] private GameObject ApproveButton;
    [SerializeField] private GameObject RemoveButton;
    GameManager Check;

    private void Start()
    {
       VoteCount =  FindObjectOfType<ModerationVoteCount>();
        Check = FindObjectOfType<GameManager>();
    }

    #region For Day0 Conditions
    public void Day0_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day0_Phishing"))
            {
                Check.isDay0_ClickBaitSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day0_ProstitutionScam"))
            {
                Check.isDay0_ProstitutionScamSelected = true;
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day0_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");
            if (gameObject.CompareTag("Day0_Phishing")&& !Check.isDay0_ClickBaitSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day0_ProstitutionScam") && !Check.isDay0_ProstitutionScamSelected)
            {
                Check.GoodCounter++;
            }

        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion


    #region For Day1 Conditions
    public void Day1_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day1_Misinformation"))
            {
                Check.isDay1_MisinformationSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day1_Phishing"))
            {
                Check.isDay1_PhishingSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day1_RiskyNews"))
            {
                Check.isDay1_RiskyNewsSelected = true;
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day1_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day1_Misinformation") && !Check.isDay1_MisinformationSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day1_Phishing") && !Check.isDay1_PhishingSelected)
            {
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion


    #region  For Day2 Conditions
    public void Day2_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day2_TravisPost1"))
            {
                Check.isDay2_TravisPost1Selected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day2_DogKilled"))
            {
                Check.isDay2_DogKilledSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day2_DepressedPerson"))
            {
                Check.isDay2_DepressedPersonSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day2_HangSuicide"))
            {
                Check.isDay2_HangSuicideSelected = true;
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day2_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day2_TravisPost1")&& !Check.isDay2_TravisPost1Selected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day2_DogKilled") && !Check.isDay2_DogKilledSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day2_DepressedPerson")&& !Check.isDay2_DepressedPersonSelected)
            {
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day2_HangSuicide") && !Check.isDay2_HangSuicideSelected)
            {
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion

    #region For Day3 Conditions
    public void Day3_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day3_HotdogCult"))
            {
                Check.isDay3_HotdogCultSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day3_Blonde"))
            {
                Check.isDay3_BlondeSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day3_TravisPost2"))
            {
                Check.isDay3_TravisPost2Selected = true;
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day3_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day3_Blonde")&& !Check.isDay3_BlondeSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day3_TravisPost2")&& !Check.isDay3_TravisPost2Selected)
            {
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion


    //Continue Adding Counters here:
    #region For Day4 Conditions
    public void Day4_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day4_EdwardCase"))
            {
                Check.isDay4_EdwardCaseSelected = true;
                Check.GoodCounter++;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day4_Screamer"))
            {
                Check.isDay4_ScreamerSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day4_Homeless"))
            {
                Check.isDay4_HomelessSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day4_DogFoundDead"))
            {
                Check.isDay4_DogFoundDeadSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day4_RiskyNews2"))
            {
                Check.isDay4_RiskyNew2sSelected = true;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day4_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day4_Screamer")&& !Check.isDay4_ScreamerSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day4_Homeless") && !Check.isDay4_HomelessSelected)
            {
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day4_DogFoundDead") && !Check.isDay4_DogFoundDeadSelected)
            {
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion

    #region For Day5 Conditions
    public void Day5_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day5_HowardDead"))
            {
                Check.isDay5_HowardDeadSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day5_StrugglingFamily"))
            {
                Check.isDay5_StrugglingFamilySelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day5_ChaoticProtest"))
            {
                Check.isDay5_ChaoticProtestSelected = true;
            }
            if (gameObject.CompareTag("Day5_BankHeist"))
            {
                Check.isDay5_BankHeistSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day5_DiyViagra"))
            {
                Check.isDay5_DiyViagraSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day5_HotdogCult2"))
            {
                Check.isDay5_HotdogCult2Selected = true;
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day5_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day5_HowardDead") && !Check.isDay5_HowardDeadSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day5_StrugglingFamily") && !Check.isDay5_StrugglingFamilySelected)
            {
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day5_BankHeist") && !Check.isDay5_BankHeistSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day5_DiyViagra") && !Check.isDay5_DiyViagraSelected)
            {
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion

    #region For Day6 Conditions
    public void Day6_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day6_HumanoidFigure"))
            {
                Check.isDay6_HumanoidFigureSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day6_Pedophile"))
            {
                Check.isDay6_PedophileSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day6_ShotDead"))
            {
                Check.isDay6_ShotDeadtSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day6_DeadBird"))
            {
                Check.isDay6_DeadBirdSelected = true;
            }
            if (gameObject.CompareTag("Day6_BirdParanoia"))
            {
                Check.isDay6_BirdParanoid = true;
            }
            if (gameObject.CompareTag("Day6_StrugglingFamilyGood"))
            {
                Check.isDay6_StrugglingFamilyGoodSelected = true;
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day6_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day6_Pedophile") && !Check.isDay6_PedophileSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day6_ShotDead") && !Check.isDay6_ShotDeadtSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day6_DeadBird") && !Check.isDay6_DeadBirdSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day6_BirdParanoia") && !Check.isDay6_BirdParanoid)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day6_StrugglingFamilyBad") && !Check.isDay6_StrugglingFamilyBadSelected)
            {
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day6_StrugglingFamilyBank") && !Check.isDay6_StrugglingFamilyBankSelected)
            {
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion

    #region For Day7 Conditions
    public void Day7_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day7_RanOver"))
            {
                Check.isDay7_RanOverSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day7_ClockPrank"))
            {
                Check.isDay7_ClockPrankSelected = true;
            }
            if (gameObject.CompareTag("Day7_Pie"))
            {
                Check.isDay7_PieSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day7_QRCode"))
            {
                Check.isDay7_QRCodeSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day7_EdwardClosure"))
            {
                Check.isDay7_EdwardClosureSelected = true;
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day7_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day7_RanOver") && !Check.isDay7_RanOverSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day7_Pie") && !Check.isDay7_PieSelected)
            {
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion

    #region For Day8 Conditions
    public void Day8_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day8_Killer"))
            {
                Check.isDay8_Killer1Selected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day8_Killer2"))
            {
                Check.isDay8_Killer2Selected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day8_Killer3"))
            {
                Check.isDay8_Killer3Selected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day8_ComputerHack"))
            {
                Check.isDay8_ComputerHackSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day8_Actress"))
            {
                Check.isDay8_ActressSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day8_Protest"))
            {
                Check.isDay8_ArmedProtestSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day8_NPPFailing"))
            {
                Check.isDay8_PowerPlantSelected = true;
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day8_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day8_Killer") && !Check.isDay8_Killer1Selected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day8_Killer2") && !Check.isDay8_Killer2Selected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day8_Killer3") && !Check.isDay8_Killer3Selected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day8_ComputerHack") && !Check.isDay8_ComputerHackSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day8_Actress") && !Check.isDay8_ActressSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day8_Protest") && Check.isDay8_ArmedProtestSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day8_NPPFailing") && !Check.isDay8_PowerPlantSelected)
            {
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion

    #region For Day9 Conditions
    public void Day9_AddVoteToApprove()
    {

        //If Player hasn't press anything yet and decides to go for Approve = +1 on counter
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess)
        {
            VoteCount.CountForApprove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateApproveCounter();
            HasPlayerVoted = true;
            RemoveButton.SetActive(false);

            Debug.Log($"This {gameObject.tag} has voted for {HasPlayerVoted}");

            //Consequence Check
            if (gameObject.CompareTag("Day9_KillerLocation"))
            {
                Check.isDay9_KillerLocationSelected = true;
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day9_GhostWeapons"))
            {
                Check.isDay9_GhostWeaponsSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Da9_SellingThesisPaper"))
            {
                Check.isDay9_SellingThesisPaperSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day9_Cyberbully"))
            {
                Check.isDay9_CyberbullySelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day9_EndangeredAnimal"))
            {
                Check.isDay9_EndangeredAnimalSelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day9_FingerInjury"))
            {
                Check.isDay9_FingerInjurySelected = true;
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day9_Protest2"))
            {
                Check.isDay9_Protest2tSelected = true;
                Check.BadCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }

    public void Day9_AddVoteToRemove()
    {
        if (!HasPlayerVoted && !VoteCount.hasSubmitProcess) //Same Principle but opposite
        {
            VoteCount.CountForRemove++;
            VoteCount.CurrentVoteCount++;

            VoteCount.UpdateRemoveCounter();
            HasPlayerVoted = true;
            ApproveButton.SetActive(false);
            Debug.Log($"This {gameObject.name} has voted for {HasPlayerVoted}");

            if (gameObject.CompareTag("Day9_KillerLocation") && !Check.isDay9_KillerLocationSelected)
            {
                Check.BadCounter++;
            }
            if (gameObject.CompareTag("Day9_GhostWeapons") && !Check.isDay9_GhostWeaponsSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Da9_SellingThesisPaper") && !Check.isDay9_SellingThesisPaperSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day9_Cyberbully") && !Check.isDay9_CyberbullySelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day9_EndangeredAnimal") && !Check.isDay9_EndangeredAnimalSelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day9_FingerInjury") && !Check.isDay9_FingerInjurySelected)
            {
                Check.GoodCounter++;
            }
            if (gameObject.CompareTag("Day9_Protest2") && Check.isDay9_Protest2tSelected)
            {
                Check.GoodCounter++;
            }
        }
        if (!HasPlayerVoted && VoteCount.hasSubmitProcess)
        {
            VoteCount.ShowUnableToVotePost();
        }
    }
    #endregion
}
