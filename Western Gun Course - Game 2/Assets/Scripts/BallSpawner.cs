using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ball;
    public float timeBetweenSpawn;
    float nextTimeToSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTimeToSpawn)
        {
            Instantiate(ball, transform.position, transform.rotation);
            nextTimeToSpawn = Time.time + timeBetweenSpawn;
        }
    }
}
