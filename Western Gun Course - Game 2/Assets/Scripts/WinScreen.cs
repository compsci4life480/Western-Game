using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public Text pointsText;
    public void Start()
    {
        Setup(PlayerDeath.totalScore);
    }
    public void Setup(double score)
    {
        //gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        pointsText.text = "SCORE: " + score.ToString() + " / 42";
    }

}
