using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public Text time;
    public Text score;
    public static double totalScore;
    bool hasDied = false;
    // Start is called before the first frame update

    void Update()
    {
        if(transform.position.y < -30 && hasDied == false || time.text == "0")
        {
            hasDied = true;
            Death();
        }

        if(score.text == "42")
        {
            Win();
        }
    }

    private void Death()
    {
        double s;
        Double.TryParse(score.text, out s);
        totalScore = s;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("EndScreen");
    }
    //This should prolly be in a separate script but for the sake of simplicity I'm putting it here
    private void Win()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("WinScreen");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Death();
        }
    }
}
