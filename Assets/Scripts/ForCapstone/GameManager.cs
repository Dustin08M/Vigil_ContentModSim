using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //Pls Check ModerationVoteCount.cs and UserVote.cs

    //This singleton sh!t
    public static GameManager instance;

    //For Loading Game, do not including in saving playerdata
    public bool HasPlayerLoadedSave;

    [Space(10)]
    [Header("For Submit Process UI")]
    public int CurrentDay;
    public string LastSceneProgress;
    public int GoodCounter;
    public int BadCounter;

    [Space(10)]
    [Header("Player Booted Up Pc")]
    //Once Booted in Day0, check and it should skip bootup scene
    public bool HasAlreadyBooted;

    [Space(10)]
    [Header("Terminal Login")]
    //Once Booted in Day0, check and it should skip bootup scene
    public bool HasAlreadyLoggedIn;

    [Space(10)]
    [Header("Violation Counter")]
    //If Violation Reaches 4, Terminate Player
    public int ViolationCount;

    [Space(10)]
    [Header("======================")]

    [Space(10)]
    [Header("For Day0: ")]
    //For Day0, pls duplicate for each day
    public bool isDay0_ClickBaitSelected;
    public bool isDay0_ProstitutionScamSelected;

    [Space(10)]
    [Header("For Day1: ")]
    public bool isDay1_MisinformationSelected;
    public bool isDay1_PhishingSelected;
    public bool isDay1_RiskyNewsSelected;

    [Space(10)]
    [Header("For Day2: ")]
    public bool isDay2_TravisPost1Selected;
    public bool isDay2_DogKilledSelected;
    public bool isDay2_DepressedPersonSelected;
    public bool isDay2_HangSuicideSelected;

    [Space(10)]
    [Header("For Day3: ")]
    public bool isDay3_HotdogCultSelected;
    public bool isDay3_BlondeSelected;
    public bool isDay3_TravisPost2Selected;

    [Space(10)]
    [Header("For Day4: ")]
    public bool isDay4_EdwardCaseSelected;
    public bool isDay4_ScreamerSelected;
    public bool isDay4_HomelessSelected;
    public bool isDay4_DogFoundDeadSelected;
    public bool isDay4_RiskyNew2sSelected;

    [Space(10)]
    [Header("For Day5: ")]
    public bool isDay5_HowardDeadSelected;
    public bool isDay5_StrugglingFamilySelected;
    public bool isDay5_ChaoticProtestSelected;
    public bool isDay5_BankHeistSelected;
    public bool isDay5_DiyViagraSelected;
    public bool isDay5_HotdogCult2Selected;

    [Space(10)]
    [Header("For Day6: ")]
    public bool isDay6_HumanoidFigureSelected;
    public bool isDay6_PedophileSelected;
    public bool isDay6_ShotDeadtSelected;
    public bool isDay6_DeadBirdSelected;
    public bool isDay6_BirdParanoid;
    public bool isDay6_StrugglingFamilyGoodSelected;
    public bool isDay6_StrugglingFamilyBadSelected;
    public bool isDay6_StrugglingFamilyBankSelected;

    [Space(10)]
    [Header("For Day7: ")]
    public bool isDay7_RanOverSelected;
    public bool isDay7_ClockPrankSelected;
    public bool isDay7_PieSelected;
    public bool isDay7_QRCodeSelected;
    public bool isDay7_EdwardClosureSelected;

    [Space(10)]
    [Header("For Day8: ")]
    public bool isDay8_Killer1Selected;
    public bool isDay8_Killer2Selected;
    public bool isDay8_Killer3Selected;
    public bool isDay8_ComputerHackSelected;
    public bool isDay8_MachoCatSelected;
    public bool isDay8_ActressSelected;
    public bool isDay8_ArmedProtestSelected;
    public bool isDay8_PowerPlantSelected;

    [Space(10)]
    [Header("For Day9: ")]
    public bool isDay9_KillerLocationSelected;
    public bool isDay9_GhostWeaponsSelected;
    public bool isDay9_SellingThesisPaperSelected;
    public bool isDay9_CyberbullySelected;
    public bool isDay9_EndangeredAnimalSelected;
    public bool isDay9_FingerInjurySelected;
    public bool isDay9_Protest2tSelected;
    public bool isDay9_PregTestSelected;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
