using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public Text pointsText;
    public void Setup(double score)
    {
        Debug.Log("BOFOFOFOFO");
        gameObject.SetActive(true);
        pointsText.text = "POINTS: " + score.ToString();
    }
}
