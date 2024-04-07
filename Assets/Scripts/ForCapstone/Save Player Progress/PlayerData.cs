using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    //For Submit Process UI
    public int save_CurrentDay;
    public string save_LastSceneProgress;
    public int save_GoodCounter;
    public int save_BadCounter;

    //For Violation UI
    public int save_ViolationCount;

    //Day0
    public bool saveDay0_ClickBait;
    public bool saveDay0_ProstitutionScamSelected;

    //Day1
    public bool saveDay1_Misinformation;
    public bool saveDay1_Phishing;
    public bool saveDay1_RiskyNews;

    //Day2
    public bool saveDay2_TravisPost1;
    public bool saveDay2_DogKilled;
    public bool saveDay2_DepressedPerson;
    public bool saveDay2_HangSuicide;

    //Day3
    public bool saveDay3_HotdogCult;
    public bool saveDay3_Blonde;
    public bool saveDay3_TravisPost2;

    //Day4
    public bool saveDay4_EdwardCase;
    public bool saveDay4_Screamer;
    public bool saveDay4_Homeless;
    public bool saveDay4_DogFoundDead;
    public bool saveDay4_RiskyNew2s;

    //Day5
    public bool saveDay5_HowardDead;
    public bool saveDay5_StrugglingFamily;
    public bool saveDay5_ChaoticProtestSelected;
    public bool saveDay5_BankHeist;
    public bool saveDay5_DiyViagra;
    public bool saveDay5_HotdogCult2;

    //Day6
    public bool saveDay6_HumanoidFigure;
    public bool saveDay6_Pedophile;
    public bool saveDay6_ShotDeadt;
    public bool saveDay6_DeadBird;
    public bool saveDay6_BirdParanoiad;
    public bool saveDay6_StrugglingFamilyGood;
    public bool saveDay6_StrugglingFamilyBad;
    public bool saveDay6_StrugglingFamilyBank;

    //Day7
    public bool saveDay7_RanOver;
    public bool saveDay7_ClockPrank;
    public bool saveDay7_Pie;
    public bool saveDay7_QRCode;
    public bool saveDay7_EdwardClosure;

    //Day8
    public bool saveDay8_Killer1;
    public bool saveDay8_Killer2;
    public bool saveDay8_Killer3;
    public bool saveDay8_ComputerHack;
    public bool saveDay8_MachoCat;
    public bool saveDay8_Actress;
    public bool saveDay8_ArmedProtest;
    public bool saveDay8_PowerPlant;

    //Day 9
    public bool saveDay9_KillerLocation;
    public bool saveDay9_GhostWeapons;
    public bool saveDay9_SellingThesisPaper;
    public bool saveDay9_Cyberbully;
    public bool saveDay9_EndangeredAnimal;
    public bool saveDay9_FingerInjury;
    public bool saveDay9_Protest;
    public bool saveDay9_PregTest;

    //for player bootup
    public bool save_HasAlreadyBooted;

    //Terminal Login
    public bool save_HasAlreadyLoggedIn;
}
