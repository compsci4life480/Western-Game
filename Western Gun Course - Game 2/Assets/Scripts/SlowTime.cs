using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowTime : MonoBehaviour
{
    public float timeModifier;
    bool timeOn = false;


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
    }
}
