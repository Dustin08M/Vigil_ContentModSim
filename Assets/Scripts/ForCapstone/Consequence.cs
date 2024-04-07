using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consequence : MonoBehaviour
{
    GameManager _inGameDay;

    
    //Player starts default in day 0, if phishing was selected, grab the phishing gameObj from next scene then enable that to see it @ in-game news
    [Space(10)]
    [Header("For Day1: ")]
    [SerializeField] private GameObject Day0_Phishing;
    [SerializeField] private GameObject Day0_Prostitution;

    [Space(10)]
    [Header("For Day2: ")]
    [SerializeField] private GameObject Day1_Misinformation;
    [SerializeField] private GameObject Day1_Phishing;
    [SerializeField] private GameObject Day1_RiskyNews; //Post a news for approve risky news post from day 1

    [Space(10)]
    [Header("For Day3: ")]
    [SerializeField] private GameObject Day2_DogKilled;
    [SerializeField] private GameObject Day2_DepressedPerson;
    [SerializeField] private GameObject Day2_HangSuicide;
    [SerializeField] private GameObject FollowUpDay2_TravisPost1;

    [Space(10)]
    [Header("For Day4: ")]
    [SerializeField] private GameObject Day3_HotDogCult;
    [SerializeField] private GameObject Day3_Blonde;
    [SerializeField] private GameObject Day2_RevengeKillonDogOwner;
    [SerializeField] private GameObject Day2_TravisPost1; //First woman from 'TravisPost1' reveal it on news
    [SerializeField] private GameObject PostDay2_RiskyNews2; //If risky news 1 is approved, enable this to get a follow up story

    [Space(10)]
    [Header("For Day5: ")]
    [SerializeField] private GameObject Day4_EdwardCase;
    [SerializeField] private GameObject Day4_Screamer;
    [SerializeField] private GameObject Day4_Homeless;
    [SerializeField] private GameObject Day4_DogFoundDead;
    [SerializeField] private GameObject Day4_RiskyNews2; //If follow up story is enabled, nibba dies a day after from accident
    [SerializeField] private GameObject Day3_TravisPost2; //Second woman from 'TravisPost2' reveal it on news
    [SerializeField] private GameObject PostDay3_HotdogCult2;

    [Space(10)]
    [Header("For Day6: ")]
    [SerializeField] private GameObject Day5_HowardDead;
    [SerializeField] private GameObject Day5_ChaoticProtest;
    [SerializeField] private GameObject Day5_BankHeist;
    [SerializeField] private GameObject Day5_DiyViagra;
    [SerializeField] private GameObject Day5_HotdogCult2;
    [SerializeField] private GameObject Day5_TravisAftermath;
    [Header("News For Family Struggling: ")]
    [SerializeField] private GameObject Day5_StrugglingFamily;
    //For Posts on Family Struggling:
    [Header("Family Struggling Posts: ")]
    [SerializeField] private GameObject PostDay6_FamilyGood;
    [SerializeField] private GameObject PostDay6_FamilyBad;
    [SerializeField] private GameObject PostDay6_FamilyBank;

    [Space(10)]
    [Header("For Day7: ")]
    [SerializeField] private GameObject Day6_HumanoidFigure;
    [SerializeField] private GameObject Day6_Pedophile;
    [SerializeField] private GameObject Day6_ShotDead;
    [SerializeField] private GameObject Day6_DeadBird;
    [SerializeField] private GameObject Day6_BirdParanoia;
    //[SerializeField] private GameObject Day6_StrugglingFamilyGood;
    [Header("Family Struggling Bad Ending on News: ")]
    [SerializeField] private GameObject Day6_StrugglingFamilyBad;
    [SerializeField] private GameObject Day6_StrugglingFamilyBank;

    [Space(10)]
    [Header("For Day8: ")]
    [SerializeField] private GameObject Day7_RanOver;
    [SerializeField] private GameObject Day7_ClockPrank;
    [SerializeField] private GameObject Day7_Pie;
    [SerializeField] private GameObject Day7_QRCode;
    [SerializeField] private GameObject Day7_EdwardClosure;
    [SerializeField] private GameObject Day7_EdwardClosureBadEnding;

    [Space(10)]
    [Header("For Day9: ")]
    [SerializeField] private GameObject Day8_KillerA;
    [SerializeField] private GameObject Day8_KillerB;
    [SerializeField] private GameObject Day8_ComputerHack;
    [SerializeField] private GameObject Day8_MachoCat;
    [SerializeField] private GameObject Day8_Actress;
    [SerializeField] private GameObject Day8_ArmedProtest;
    [SerializeField] private GameObject Day8_PowerPlant;

    [Space(10)]
    [Header("For Day10: ")]
    [SerializeField] private GameObject Day9_KillerLocation;
    [SerializeField] private GameObject Day9_SellingWeapon;
    [SerializeField] private GameObject Day9_SellingThesis;
    [SerializeField] private GameObject Day9_Cybully;
    [SerializeField] private GameObject Day9_IllegalHunting;
    [SerializeField] private GameObject Day9_FingerInjury;
    [SerializeField] private GameObject Day9_ProtestRecruit;
    [SerializeField] private GameObject Day9_DestructivePregnancyTest;




    void Start()
    {
        _inGameDay = FindObjectOfType<GameManager>();
        CheckIfConsequence_Selected();
        CheckConsequences();
    }

    //If 'GameObject' Consequences doesnt show up in scene, return it
    #region CheckBooleanValues
    void CheckConsequences()
    {
        if (Day0_Phishing == null) return;
        if (Day0_Prostitution == null) return;

        if (Day1_Misinformation == null) return;
        if (Day1_Phishing == null) return;
        if (Day1_RiskyNews == null) return;

        if (Day2_TravisPost1 == null) return;
        if (Day2_DogKilled == null) return;
        if (Day2_DepressedPerson == null) return;
        if (Day2_HangSuicide == null) return;

        if (Day3_Blonde == null) return;
        if (Day3_HotDogCult == null) return;
        if (Day3_TravisPost2 == null) return;
        if (Day2_RevengeKillonDogOwner == null) return;
        if(FollowUpDay2_TravisPost1 == null) return;
        if (PostDay2_RiskyNews2 == null) return;

        if (Day4_EdwardCase == null) return;
        if (Day4_Screamer == null) return;
        if (Day4_Homeless == null) return;
        if (Day4_DogFoundDead == null) return;
        if (Day4_RiskyNews2 == null) return;

        if (Day5_HowardDead == null) return;
        if (Day5_StrugglingFamily == null) return;
        if (Day5_ChaoticProtest == null) return;
        if (Day5_DiyViagra == null) return;
        if (Day5_HotdogCult2 == null) return;
        if (Day5_TravisAftermath == null) return;
        if (PostDay3_HotdogCult2 == null) return;

        if (Day6_HumanoidFigure == null) return;
        if (Day6_Pedophile == null) return;
        if (Day6_ShotDead == null) return;
        if (Day6_DeadBird == null) return;
        if (Day6_BirdParanoia == null) return;

        //if (Day6_StrugglingFamilyGood == null) return;

        if (Day6_StrugglingFamilyBad == null) return;
        if (Day6_StrugglingFamilyBank == null) return;

        if (PostDay6_FamilyGood == null) return;
        if (PostDay6_FamilyBad == null) return;
        if (PostDay6_FamilyBank == null) return;

        if (Day7_RanOver == null) return;
        if(Day7_ClockPrank == null) return;
        if (Day7_Pie == null) return;
        if (Day7_QRCode == null) return;
        if(Day7_EdwardClosure == null) return;
        if (Day7_EdwardClosureBadEnding == null) return;

        if (Day8_KillerA == null) return;
        if (Day8_KillerB == null) return;
        if (Day8_ComputerHack == null) return;
        if (Day8_MachoCat == null) return;
        if (Day8_Actress == null) return;
        if (Day8_ArmedProtest == null) return;
        if (Day8_PowerPlant == null) return;

        if (Day9_KillerLocation == null) return;
        if (Day9_SellingWeapon == null) return;
        if (Day9_SellingThesis == null) return;
        if (Day9_Cybully == null) return;
        if (Day9_IllegalHunting == null) return;
        if (Day9_FingerInjury == null) return;
        if (Day9_ProtestRecruit == null) return;
        if (Day9_DestructivePregnancyTest == null) return;
    }
    #endregion

    #region Check If Consequences are Selected
    void CheckIfConsequence_Selected()
    {
        //If Player Logouts out and is Day 1, any actions taken will result in the following day via in-game news
        //Show Consequence of Players the next day

        if (_inGameDay.CurrentDay == 1)
        {
            if (_inGameDay.isDay0_ClickBaitSelected) Day0_Phishing.SetActive(true);
            if (_inGameDay.isDay0_ProstitutionScamSelected) Day0_Prostitution.SetActive(true);
        }

        if (_inGameDay.CurrentDay == 2)
        {
            if (_inGameDay.isDay1_MisinformationSelected) Day1_Misinformation.SetActive(true);
            if (_inGameDay.isDay1_PhishingSelected) Day1_Phishing.SetActive(true);
            if (_inGameDay.isDay1_RiskyNewsSelected) Day1_RiskyNews.SetActive(true);
        }
        if (_inGameDay.CurrentDay == 3)
        {
            if (_inGameDay.isDay2_DogKilledSelected) Day2_DogKilled.SetActive(true);
            if (!_inGameDay.isDay2_DepressedPersonSelected) Day2_DepressedPerson.SetActive(true);
            if (_inGameDay.isDay2_HangSuicideSelected) Day2_HangSuicide.SetActive(true);
            //If 'TravisPost1' is approved another post appears for another victim
            if (_inGameDay.isDay2_TravisPost1Selected) FollowUpDay2_TravisPost1.SetActive(true);
        }
        if (_inGameDay.CurrentDay == 4)
        {
            //Travis news on missing woman appear here
            if (_inGameDay.isDay2_TravisPost1Selected) Day2_TravisPost1.SetActive(true);

            if (_inGameDay.isDay3_HotdogCultSelected) Day3_HotDogCult.SetActive(true);
            if (_inGameDay.isDay3_BlondeSelected) Day3_Blonde.SetActive(true);

            //User comes after the guy who killed his dog, then reveal it on news
            if (_inGameDay.isDay2_DogKilledSelected) Day2_RevengeKillonDogOwner.SetActive(true);

            //If 'RiskyNews1' is approved
            if (_inGameDay.isDay1_RiskyNewsSelected) PostDay2_RiskyNews2.SetActive(true);
        }
        if (_inGameDay.CurrentDay == 5)
        {
            //Appears again if approved, 2nd missing woman
            if (_inGameDay.isDay3_TravisPost2Selected) Day3_TravisPost2.SetActive(true);
            if (_inGameDay.isDay4_EdwardCaseSelected) Day4_EdwardCase.SetActive(true);
            if (_inGameDay.isDay4_ScreamerSelected) Day4_Screamer.SetActive(true);
            if (_inGameDay.isDay4_HomelessSelected) Day4_Homeless.SetActive(true);
            if (_inGameDay.isDay4_DogFoundDeadSelected) Day4_DogFoundDead.SetActive(true);
            if (_inGameDay.isDay4_RiskyNew2sSelected) Day4_RiskyNews2.SetActive(true);
            if (_inGameDay.isDay3_HotdogCultSelected) Day5_HotdogCult2.SetActive(true);
            if (_inGameDay.isDay3_HotdogCultSelected) PostDay3_HotdogCult2.SetActive(true);
        }

        if (_inGameDay.CurrentDay == 6)
        {
            if (_inGameDay.isDay5_HowardDeadSelected) Day5_HowardDead.SetActive(true);

            //News on Family Being Helped (If Approved)
            if (_inGameDay.isDay5_StrugglingFamilySelected)
            {
                Day5_StrugglingFamily.SetActive(true);
                //Show Family Post Saying thanks:
                PostDay6_FamilyGood.SetActive(true);
            }
            //If Ignored
            if (!_inGameDay.isDay5_StrugglingFamilySelected)
            {
                //Show Post on Father about to do crime (burglary)
                PostDay6_FamilyBad.SetActive(true);
            }
            //If Ignored and Approve Bank Heist
            if (!_inGameDay.isDay5_StrugglingFamilySelected && _inGameDay.isDay5_BankHeistSelected)
            {
                //Show Post on Father about to join bank heist
                PostDay6_FamilyBank.SetActive(true);
            }

            if (_inGameDay.isDay5_ChaoticProtestSelected) Day5_ChaoticProtest.SetActive(true);

            //If player removes, user will end up doing it himself and died in police shootout
            if (_inGameDay.isDay5_BankHeistSelected) Day5_BankHeist.SetActive(true);
            if (_inGameDay.isDay5_DiyViagraSelected) Day5_DiyViagra.SetActive(true);
            if (_inGameDay.isDay5_HotdogCult2Selected) Day5_HotdogCult2.SetActive(true);
            if (_inGameDay.isDay2_TravisPost1Selected || _inGameDay.isDay3_TravisPost2Selected) Day5_TravisAftermath.SetActive(true);
        }

        if (_inGameDay.CurrentDay == 7)
        {
            if (_inGameDay.isDay6_HumanoidFigureSelected) Day6_HumanoidFigure.SetActive(true);
            if (_inGameDay.isDay6_PedophileSelected) Day6_Pedophile.SetActive(true);
            if (_inGameDay.isDay6_ShotDeadtSelected) Day6_ShotDead.SetActive(true);
            if (_inGameDay.isDay6_DeadBirdSelected) Day6_DeadBird.SetActive(true);
            if (_inGameDay.isDay6_BirdParanoid) Day6_BirdParanoia.SetActive(true);

            //Once all posts are done, get back here and fix this shit
            //News on family being help and show it went popular
            //Update: cancel that shiet since its already on news at day 6
            //if (_inGameDay.isDay6_StrugglingFamilyGoodSelected) Day6_StrugglingFamilyGood.SetActive(true);

            //News on father ended up as burglar and died while attempt to run away from authorities, mother and child state remains uknown
            if (!_inGameDay.isDay6_StrugglingFamilyBadSelected && !_inGameDay.isDay5_BankHeistSelected) Day6_StrugglingFamilyBad.SetActive(true);

            //News on Heist group died in shootout while fleeing, mother and child still remains unknown
            if (!_inGameDay.isDay6_StrugglingFamilyBadSelected && _inGameDay.isDay5_BankHeistSelected) Day6_StrugglingFamilyBank.SetActive(true);
        }
        if (_inGameDay.CurrentDay == 8)
        {
            if (_inGameDay.isDay7_RanOverSelected) Day7_RanOver.SetActive(true);
            if (_inGameDay.isDay7_ClockPrankSelected) Day7_ClockPrank.SetActive(true);
            if (_inGameDay.isDay7_PieSelected) Day7_Pie.SetActive(true);
            if (_inGameDay.isDay7_QRCodeSelected) Day7_QRCode.SetActive(true);
            if (_inGameDay.isDay7_EdwardClosureSelected && _inGameDay.isDay4_EdwardCaseSelected) Day7_EdwardClosure.SetActive(true);
            if (!_inGameDay.isDay4_EdwardCaseSelected) Day7_EdwardClosureBadEnding.SetActive(true);
        }

        if (_inGameDay.CurrentDay == 9)
        {
            if (_inGameDay.isDay8_Killer1Selected || _inGameDay.isDay8_Killer2Selected || _inGameDay.isDay8_Killer3Selected) Day8_KillerA.SetActive(true);
            if (_inGameDay.isDay8_Killer1Selected && _inGameDay.isDay8_Killer2Selected && _inGameDay.isDay8_Killer3Selected) Day8_KillerB.SetActive(true);

            if (_inGameDay.isDay8_ComputerHackSelected) Day8_ComputerHack.SetActive(true);
            if (_inGameDay.isDay8_MachoCatSelected) Day8_MachoCat.SetActive(true);
            if (_inGameDay.isDay8_ActressSelected) Day8_Actress.SetActive(true);
            if (_inGameDay.isDay8_ArmedProtestSelected) Day8_ArmedProtest.SetActive(true);
            if (_inGameDay.isDay8_PowerPlantSelected) Day8_PowerPlant.SetActive(true);
        }
        if (_inGameDay.CurrentDay == 10) //Ending
        {
            //...Thinking...
            // Nahhh forget it, this is the ending, boyo
        }
    }
    #endregion
}
