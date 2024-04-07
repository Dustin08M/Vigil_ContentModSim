using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerViolation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Violation1;
    [SerializeField] private GameObject Violation2;
    [SerializeField] private GameObject Violation3;
    GameManager checkViolation;
    void Start()
    {
        checkViolation = FindObjectOfType<GameManager>();
        if (checkViolation.ViolationCount == 1)
        {
            Violation1.SetActive(true);
        }
        if (checkViolation.ViolationCount == 2)
        {
            Violation1.SetActive(true);
            Violation2.SetActive(true);
        }
        if (checkViolation.ViolationCount == 3)
        {
            Violation1.SetActive(true);
            Violation3.SetActive(true);
            Violation3.SetActive(true);
        }
    }
}
