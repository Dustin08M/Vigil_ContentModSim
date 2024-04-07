using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FadeDayCount : MonoBehaviour
{
    public Animator animate;
    public TMP_Text Disp_DayText;
    GameManager dayCount;

    private void Start()
    {
        animate = GetComponent<Animator>();
        dayCount = FindAnyObjectByType<GameManager>();
        Disp_DayText.text = "Day " + dayCount.CurrentDay;
        ShowDayCountAnimation();
    }
    public void ShowDayCountAnimation()
    {
        animate.SetTrigger("TR_ShowDayCount");
    }
}
