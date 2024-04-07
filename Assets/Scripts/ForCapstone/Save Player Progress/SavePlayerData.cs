using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class SavePlayerData : MonoBehaviour
{
    // Load State void at '_gameManager.CurrentDay = playerData.save_CurrentDay' has added to '+1';
    //Update: Help here: https://youtu.be/TkQsrkA_7WY?si=8U1KWCz50HcHR_OL&t=56
    //Update: No do not, I just forgot to mention this shit at void start

    GameManager _gameManager;
    private string savePath;

    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
/*        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GameMenu"))
        {
            LoadPlayerDataStats();
        }*/
    }
    public void SavePlayerDataStats()
    {
        //Creating Data
        PlayerData playerData = new PlayerData();
        //This is crucial aight, name of player data, then class variable inside
        //then pair it with Game Manager's variable like this:

        
        //Submit Process UI
        playerData.save_CurrentDay = _gameManager.CurrentDay;
        playerData.save_LastSceneProgress = _gameManager.LastSceneProgress;
        playerData.save_GoodCounter = _gameManager.GoodCounter;
        playerData.save_BadCounter = _gameManager.BadCounter;

        //Violation Counter for Terminated Ending
        playerData.save_ViolationCount = _gameManager.ViolationCount;

        playerData.saveDay0_ClickBait = _gameManager.isDay0_ClickBaitSelected;
        playerData.saveDay0_ProstitutionScamSelected = _gameManager.isDay0_ProstitutionScamSelected;

        playerData.saveDay1_Misinformation = _gameManager.isDay1_MisinformationSelected;
        playerData.saveDay1_Phishing = _gameManager.isDay1_PhishingSelected;
        playerData.saveDay1_RiskyNews = _gameManager.isDay1_RiskyNewsSelected;


        //I hear Jerusalem bells a-ringin'
        playerData.saveDay2_TravisPost1 = _gameManager.isDay2_TravisPost1Selected;
        playerData.saveDay2_DogKilled = _gameManager.isDay2_DogKilledSelected;
        playerData.saveDay2_DepressedPerson = _gameManager.isDay2_DepressedPersonSelected;
        playerData.saveDay2_HangSuicide = _gameManager.isDay2_HangSuicideSelected;

        playerData.saveDay3_HotdogCult = _gameManager.isDay3_HotdogCultSelected;
        playerData.saveDay3_Blonde = _gameManager.isDay3_BlondeSelected;
        playerData.saveDay3_TravisPost2 = _gameManager.isDay3_TravisPost2Selected;

        //Roman Cavalry choirs are singin'
        playerData.saveDay4_EdwardCase = _gameManager.isDay4_EdwardCaseSelected;
        playerData.saveDay4_Screamer = _gameManager.isDay4_ScreamerSelected;
        playerData.saveDay4_Homeless = _gameManager.isDay4_HomelessSelected;
        playerData.saveDay4_DogFoundDead = _gameManager.isDay4_DogFoundDeadSelected;
        playerData.saveDay4_RiskyNew2s = _gameManager.isDay4_RiskyNew2sSelected;

        playerData.saveDay5_HowardDead = _gameManager.isDay5_HowardDeadSelected;
        playerData.saveDay5_StrugglingFamily = _gameManager.isDay5_StrugglingFamilySelected;
        playerData.saveDay5_ChaoticProtestSelected = _gameManager.isDay5_ChaoticProtestSelected;
        playerData.saveDay5_BankHeist = _gameManager.isDay5_BankHeistSelected;
        playerData.saveDay5_DiyViagra = _gameManager.isDay5_DiyViagraSelected;
        playerData.saveDay5_HotdogCult2 = _gameManager.isDay5_HotdogCult2Selected;

        //Be my mirror, my sword and shield
        playerData.saveDay6_HumanoidFigure = _gameManager.isDay6_HumanoidFigureSelected;
        playerData.saveDay6_Pedophile = _gameManager.isDay6_PedophileSelected;
        playerData.saveDay6_ShotDeadt = _gameManager.isDay6_ShotDeadtSelected;
        playerData.saveDay6_DeadBird = _gameManager.isDay6_ShotDeadtSelected;
        playerData.saveDay6_BirdParanoiad = _gameManager.isDay6_BirdParanoid;
        playerData.saveDay6_StrugglingFamilyGood = _gameManager.isDay6_StrugglingFamilyGoodSelected;
        playerData.saveDay6_StrugglingFamilyBad = _gameManager.isDay6_StrugglingFamilyBadSelected;
        playerData.saveDay6_StrugglingFamilyBank = _gameManager.isDay6_StrugglingFamilyBankSelected;

        playerData.saveDay7_RanOver = _gameManager.isDay7_RanOverSelected;
        playerData.saveDay7_ClockPrank = _gameManager.isDay7_ClockPrankSelected;
        playerData.saveDay7_Pie =_gameManager.isDay7_PieSelected;
        playerData.saveDay7_QRCode = _gameManager.isDay7_QRCodeSelected;
        playerData.saveDay7_EdwardClosure = _gameManager.isDay7_EdwardClosureSelected;

        //My missionaries in a foreign field
        playerData.saveDay8_Killer1 = _gameManager.isDay8_Killer1Selected;
        playerData.saveDay8_Killer2 = _gameManager.isDay8_Killer2Selected;
        playerData.saveDay8_Killer3 = _gameManager.isDay8_Killer3Selected;
        playerData.saveDay8_ComputerHack = _gameManager.isDay8_ComputerHackSelected;
        playerData.saveDay8_MachoCat = _gameManager.isDay8_MachoCatSelected;
        playerData.saveDay8_Actress = _gameManager.isDay8_ActressSelected;
        playerData.saveDay8_ArmedProtest = _gameManager.isDay8_ArmedProtestSelected;
        playerData.saveDay8_PowerPlant = _gameManager.isDay8_PowerPlantSelected;

        playerData.saveDay9_KillerLocation = _gameManager.isDay9_KillerLocationSelected;
        playerData.saveDay9_GhostWeapons = _gameManager.isDay9_GhostWeaponsSelected;
        playerData.saveDay9_SellingThesisPaper = _gameManager.isDay9_SellingThesisPaperSelected;
        playerData.saveDay9_Cyberbully = _gameManager.isDay9_CyberbullySelected;
        playerData.saveDay9_EndangeredAnimal = _gameManager.isDay9_EndangeredAnimalSelected;
        playerData.saveDay9_FingerInjury = _gameManager.isDay9_FingerInjurySelected;
        playerData.saveDay9_Protest = _gameManager.isDay9_Protest2tSelected;
        playerData.saveDay9_PregTest = _gameManager.isDay9_PregTestSelected;

        //For some reason, I can't explain
        playerData.save_HasAlreadyBooted = _gameManager.HasAlreadyBooted;
        playerData.save_HasAlreadyLoggedIn = _gameManager.HasAlreadyLoggedIn;


    //Once its done, write it to Json and hope he fking reads it
    //Tell Json to read it fast
    string json = JsonUtility.ToJson(playerData);
        File.WriteAllText("VigilPlayerFile.json", json);
        //Debug.Log($"Saving: {json} with {Playerstats.PlayerSample}, {Playerstats.PlayerHP}, and {Playerstats.MoveSpeed}");
    }

    public void LoadPlayerDataStats()
    {

        if (File.Exists("VigilPlayerFile.json"))
        {
            string json = File.ReadAllText("VigilPlayerFile.json");
            PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);


            _gameManager.CurrentDay = playerData.save_CurrentDay;
            _gameManager.LastSceneProgress = playerData.save_LastSceneProgress;
            _gameManager.GoodCounter = playerData.save_GoodCounter;
            _gameManager.BadCounter = playerData.save_BadCounter;

            _gameManager.ViolationCount = playerData.save_ViolationCount;

            _gameManager.isDay0_ClickBaitSelected = playerData.saveDay0_ClickBait;
            _gameManager.isDay0_ProstitutionScamSelected = playerData.saveDay0_ProstitutionScamSelected;

            _gameManager.isDay1_MisinformationSelected = playerData.saveDay1_Misinformation;
            _gameManager.isDay1_PhishingSelected = playerData.saveDay1_Phishing;
            _gameManager.isDay1_RiskyNewsSelected = playerData.saveDay1_RiskyNews;

            //I know Saint Peter won't call my name
            _gameManager.isDay2_TravisPost1Selected = playerData.saveDay2_TravisPost1;
            _gameManager.isDay2_DogKilledSelected = playerData.saveDay2_DogKilled;
            _gameManager.isDay2_DepressedPersonSelected = playerData.saveDay2_DepressedPerson;
            _gameManager.isDay2_HangSuicideSelected = playerData.saveDay2_HangSuicide;

            _gameManager.isDay3_HotdogCultSelected = playerData.saveDay3_HotdogCult;
            _gameManager.isDay3_BlondeSelected = playerData.saveDay3_Blonde;
            _gameManager.isDay3_TravisPost2Selected = playerData.saveDay3_TravisPost2;

            //Never an honest word
            _gameManager.isDay4_EdwardCaseSelected = playerData.saveDay4_EdwardCase;
            _gameManager.isDay4_ScreamerSelected = playerData.saveDay4_Screamer;
            _gameManager.isDay4_HomelessSelected = playerData.saveDay4_Homeless;
            _gameManager.isDay4_DogFoundDeadSelected = playerData.saveDay4_DogFoundDead;
            _gameManager.isDay4_RiskyNew2sSelected = playerData.saveDay4_RiskyNew2s;

            //But that was when I ruled the world
            _gameManager.isDay5_HowardDeadSelected = playerData.saveDay5_HowardDead;
            _gameManager.isDay5_StrugglingFamilySelected = playerData.saveDay5_StrugglingFamily;
            _gameManager.isDay5_ChaoticProtestSelected = playerData.saveDay5_ChaoticProtestSelected;
            _gameManager.isDay5_BankHeistSelected = playerData.saveDay5_BankHeist;
            _gameManager.isDay5_DiyViagraSelected = playerData.saveDay5_DiyViagra;
            _gameManager.isDay5_HotdogCult2Selected = playerData.saveDay5_HotdogCult2;

            _gameManager.isDay6_HumanoidFigureSelected = playerData.saveDay6_HumanoidFigure;
            _gameManager.isDay6_PedophileSelected = playerData.saveDay6_Pedophile;
            _gameManager.isDay6_ShotDeadtSelected = playerData.saveDay6_ShotDeadt;
            _gameManager.isDay6_ShotDeadtSelected = playerData.saveDay6_DeadBird;
            _gameManager.isDay6_BirdParanoid = playerData.saveDay6_BirdParanoiad;
            _gameManager.isDay6_StrugglingFamilyGoodSelected = playerData.saveDay6_StrugglingFamilyGood;
            _gameManager.isDay6_StrugglingFamilyBadSelected = playerData.saveDay6_StrugglingFamilyBad;
            _gameManager.isDay6_StrugglingFamilyBankSelected = playerData.saveDay6_StrugglingFamilyBank;

            _gameManager.isDay7_RanOverSelected = playerData.saveDay7_RanOver;
            _gameManager.isDay7_ClockPrankSelected = playerData.saveDay7_ClockPrank;
            _gameManager.isDay7_PieSelected = playerData.saveDay7_Pie;
            _gameManager.isDay7_QRCodeSelected = playerData.saveDay7_QRCode;
            _gameManager.isDay7_EdwardClosureSelected = playerData.saveDay7_EdwardClosure;

            _gameManager.isDay8_Killer1Selected = playerData.saveDay8_Killer1;
            _gameManager.isDay8_Killer2Selected = playerData.saveDay8_Killer2;
            _gameManager.isDay8_Killer3Selected = playerData.saveDay8_Killer3;
            _gameManager.isDay8_ComputerHackSelected = playerData.saveDay8_ComputerHack;
            _gameManager.isDay8_MachoCatSelected = playerData.saveDay8_MachoCat;
            _gameManager.isDay8_ActressSelected = playerData.saveDay8_Actress;
            _gameManager.isDay8_ArmedProtestSelected = playerData.saveDay8_ArmedProtest;
            _gameManager.isDay8_PowerPlantSelected = playerData.saveDay8_PowerPlant;

            _gameManager.isDay9_KillerLocationSelected = playerData.saveDay9_KillerLocation;
            _gameManager.isDay9_GhostWeaponsSelected = playerData.saveDay9_GhostWeapons;
            _gameManager.isDay9_SellingThesisPaperSelected = playerData.saveDay9_SellingThesisPaper;
            _gameManager.isDay9_CyberbullySelected = playerData.saveDay9_Cyberbully;
            _gameManager.isDay9_EndangeredAnimalSelected = playerData.saveDay9_EndangeredAnimal;
            _gameManager.isDay9_FingerInjurySelected = playerData.saveDay9_FingerInjury;
            _gameManager.isDay9_Protest2tSelected = playerData.saveDay9_Protest;
            _gameManager.isDay9_PregTestSelected = playerData.saveDay9_PregTest;

            _gameManager.HasAlreadyBooted = playerData.save_HasAlreadyBooted;
            _gameManager.HasAlreadyLoggedIn = playerData.save_HasAlreadyLoggedIn;
        }
        else Debug.LogWarning("No saved player data found.");

    }
}
