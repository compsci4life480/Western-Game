using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    CharacterController controller;
    //public Text time;
    public Text score;
    public static double totalScore;
    public GameOverScreen GameOverScreen;
    bool hasDied = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if(transform.position.y < -30 && hasDied == false)
        {
            hasDied = true;
            Death();
        }
    }

    //if death, switch to end screen with time and score displayed
    private void Death()
    {
        double s;
        Double.TryParse(score.text, out s);
        totalScore = s;
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("EndScreen");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Death();
        }
    }
}
