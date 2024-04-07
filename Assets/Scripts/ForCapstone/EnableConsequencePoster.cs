using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnableConsequencePoster : MonoBehaviour
{
    GameManager _checkCondition;
    [SerializeField] private GameObject Phishing_Poster;
    [SerializeField] private GameObject Misinformation_Poster;
    [SerializeField] private GameObject Suicide_Poster;
    [SerializeField] private GameObject HotDog1_Poster;
    [SerializeField] private GameObject HotDog1_Email;
    [SerializeField] private GameObject HotDog2_Poster;
    [SerializeField] private GameObject AlarmClocks;
    [SerializeField] private GameObject AlarmClocks_Email;
    [SerializeField] private GameObject QRcode_Poster;
    [SerializeField] private GameObject Hacked_Poster;
    // Start is called before the first frame update

    private void Awake()
    {
        _checkCondition = FindObjectOfType<GameManager>();
    }
    void Start()
    {
        Check_on_Missing_Posters();
        Check_Current_Day();
    }

    void Check_Current_Day()
    {
        // if some conditions are true, display them next day
        int Day = _checkCondition.CurrentDay;
        switch (Day)
        {
            case 1:
                if (_checkCondition.isDay0_ClickBaitSelected)
                    Phishing_Poster.SetActive(true);
                break;
            case 2:
                if (_checkCondition.isDay1_PhishingSelected)
                    Phishing_Poster.SetActive(true);
                if (_checkCondition.isDay1_MisinformationSelected)
                    Misinformation_Poster.SetActive(true);
                break;
            case 3:
                if (_checkCondition.isDay2_DepressedPersonSelected || _checkCondition.isDay2_HangSuicideSelected)
                    Suicide_Poster.SetActive(true);
                break;
            case 4:
                if (_checkCondition.isDay3_HotdogCultSelected)
                    HotDog1_Poster.SetActive(true);
                break;
            case 5:
                if (_checkCondition.isDay3_HotdogCultSelected)
                {
                    HotDog1_Poster.SetActive(true);
                    HotDog1_Email.SetActive(true);
                }
                break;
            case 6:
                if (_checkCondition.isDay3_HotdogCultSelected)
                    HotDog1_Poster.SetActive(true);
                if (_checkCondition.isDay5_HotdogCult2Selected)
                    HotDog2_Poster.SetActive(true);
                break;
            case 7:
                if (_checkCondition.isDay3_HotdogCultSelected)
                    HotDog1_Poster.SetActive(true);
                if (_checkCondition.isDay5_HotdogCult2Selected)
                    HotDog2_Poster.SetActive(true);
                break;
            case 8:
                if (_checkCondition.isDay7_ClockPrankSelected)
                {

                    AlarmClocks.SetActive(true);
                    AlarmClocks_Email.SetActive(true);
                }
                if (_checkCondition.isDay7_QRCodeSelected)
                    QRcode_Poster.SetActive(true);
                break;
            case 9:
                if (_checkCondition.isDay8_ComputerHackSelected)
                    Hacked_Poster.SetActive(true);
                break;
        }
    }

    void Check_on_Missing_Posters()
    {
        if (Phishing_Poster == null) return;
        if (Misinformation_Poster == null) return;
        if (Suicide_Poster == null) return;
        if (HotDog1_Poster == null) return;
        if (HotDog1_Email == null) return;
        if (HotDog2_Poster == null) return;
        if (AlarmClocks == null) return;
        if (AlarmClocks_Email == null) return;
        if (QRcode_Poster == null) return;
        if (Hacked_Poster == null) return;
    }
}
