using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float timeModifier;
    bool timeOn = false;

    private void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && !timeOn)
        {
            Time.timeScale = timeModifier;
            timeOn = true;
        }else if(Input.GetKeyDown(KeyCode.T) && timeOn)
        {
            Time.timeScale = 1;
            timeOn = false;
        }
        if(Input.GetKeyDown(KeyCode.Y) && !timeOn)
        {
            Time.timeScale = 2 - timeModifier;
            timeOn = true;
        }else if (Input.GetKeyDown(KeyCode.Y) && timeOn)
        {
            Time.timeScale = 1;
            timeOn = false;
        }
    }
}
