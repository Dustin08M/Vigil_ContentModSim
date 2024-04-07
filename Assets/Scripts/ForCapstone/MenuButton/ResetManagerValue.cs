using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetManagerValue : MonoBehaviour
{
    GameManager _gameManager;
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    public void ResetGameManager()
    {
        _gameManager.CurrentDay = 0;
        _gameManager.LastSceneProgress = "";
        _gameManager.GoodCounter = 0;
        _gameManager.BadCounter = 0;

        _gameManager.HasAlreadyBooted = false;

        _gameManager.HasAlreadyLoggedIn = false;

        _gameManager.ViolationCount = 0;

        _gameManager.isDay0_ClickBaitSelected = false;
        _gameManager.isDay0_ProstitutionScamSelected = false;

        _gameManager.isDay1_MisinformationSelected = false;
        _gameManager.isDay1_RiskyNewsSelected = false;
        _gameManager.isDay1_PhishingSelected = false;

        _gameManager.isDay2_TravisPost1Selected = false;
        _gameManager.isDay2_DogKilledSelected = false;
        _gameManager.isDay2_DepressedPersonSelected = false;
        _gameManager.isDay2_HangSuicideSelected = false;

        _gameManager.isDay3_HotdogCultSelected = false;
        _gameManager.isDay3_BlondeSelected = false;
        _gameManager.isDay3_TravisPost2Selected = false;

        _gameManager.isDay4_EdwardCaseSelected = false;
        _gameManager.isDay4_ScreamerSelected = false;
        _gameManager.isDay4_HomelessSelected = false;
        _gameManager.isDay4_DogFoundDeadSelected = false;
        _gameManager.isDay4_RiskyNew2sSelected = false;

        _gameManager.isDay5_HowardDeadSelected = false;
        _gameManager.isDay5_StrugglingFamilySelected = false;
        _gameManager.isDay5_ChaoticProtestSelected = false;
        _gameManager.isDay5_BankHeistSelected = false;
        _gameManager.isDay5_DiyViagraSelected = false;
        _gameManager.isDay5_HotdogCult2Selected = false;

        _gameManager.isDay6_HumanoidFigureSelected = false;
        _gameManager.isDay6_PedophileSelected = false;
        _gameManager.isDay6_ShotDeadtSelected = false;
        _gameManager.isDay6_DeadBirdSelected = false;
        _gameManager.isDay6_BirdParanoid = false;
        _gameManager.isDay6_StrugglingFamilyGoodSelected = false;
        _gameManager.isDay6_StrugglingFamilyBadSelected = false;
        _gameManager.isDay6_StrugglingFamilyBankSelected = false;

        _gameManager.isDay7_RanOverSelected = false;
        _gameManager.isDay7_ClockPrankSelected = false;
        _gameManager.isDay7_PieSelected = false;
        _gameManager.isDay7_QRCodeSelected = false;
        _gameManager.isDay7_EdwardClosureSelected = false;

        _gameManager.isDay8_Killer1Selected = false;
        _gameManager.isDay8_Killer2Selected = false;
        _gameManager.isDay8_Killer3Selected = false;
        _gameManager.isDay8_ComputerHackSelected = false;
        _gameManager.isDay8_MachoCatSelected = false;
        _gameManager.isDay8_ActressSelected = false;
        _gameManager.isDay8_ArmedProtestSelected = false;
        _gameManager.isDay8_PowerPlantSelected = false;

        _gameManager.isDay9_KillerLocationSelected = false;
        _gameManager.isDay9_GhostWeaponsSelected = false;
        _gameManager.isDay9_GhostWeaponsSelected = false;
        _gameManager.isDay9_SellingThesisPaperSelected = false;
        _gameManager.isDay9_CyberbullySelected = false;
        _gameManager.isDay9_EndangeredAnimalSelected = false;
        _gameManager.isDay9_FingerInjurySelected = false;
        _gameManager.isDay9_Protest2tSelected = false;
        _gameManager.isDay9_PregTestSelected = false;
    }
}
