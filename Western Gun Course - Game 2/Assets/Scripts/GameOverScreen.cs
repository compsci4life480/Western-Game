using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public Text pointsText;
    public void Start()
    {
        Setup(PlayerDeath.totalScore);
    }
    public void Setup(double score)
    {
        gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        pointsText.text = "POINTS: " + score.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Playground");
    }
}
