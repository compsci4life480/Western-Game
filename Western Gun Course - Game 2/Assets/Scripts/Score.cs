using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int scoreNumb = 0;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
    }

    // Update is called once per frame
    void UpdateScore()
    {
        scoreNumb++;
        score.text = scoreNumb.ToString();
    }
}
