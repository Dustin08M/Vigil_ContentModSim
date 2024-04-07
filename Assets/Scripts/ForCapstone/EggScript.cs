using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EggScript : MonoBehaviour
{
    public TMP_Text ScoreText;
    int Count;
    public Vector3 Eggsize;


    private void Start()
    {
        ScoreText.text = Count.ToString();
        Eggsize = new Vector3(1, 1, 1);
        gameObject.transform.localScale = Eggsize;
    }
    public void CountClick()
    {
        Count++;
        ScoreText.text = Count.ToString();
    }

    public void SetEggSize()
    {
        Eggsize = new Vector3(transform.localScale.x - .05f, transform.localScale.y - .05f, transform.localScale.z - .05f);
        this.gameObject.transform.localScale = Eggsize;
    }
    public void ResetEggSize()
    {
        Eggsize = new Vector3(transform.localScale.x + .05f, transform.localScale.y + .05f, transform.localScale.z + .05f);
        this.gameObject.transform.localScale = Eggsize;
    }
}
