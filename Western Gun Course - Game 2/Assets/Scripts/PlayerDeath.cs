using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    CharacterController controller;
    public Text time;
    public Text score;
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    //if death, switch to end screen with time and score displayed
    private void Death()
    {
        //double.Parse(time.ToString()) + double.Parse(score.ToString())
        double s;
        Double.TryParse(score.ToString(), out s);
        GameOverScreen.Setup(s);
        //SceneManager.LoadScene(sceneName: "default");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball" || transform.position.y < 0)
        {
            Death();
        }
    }
}
