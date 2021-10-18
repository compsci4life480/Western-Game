using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ball;
    public float timeBetweenSpawn;
    public float timeToStart;
    float nextTimeToSpawn = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > timeToStart)
        {
            //spawns incrementally
            if (Time.time >= nextTimeToSpawn)
            {
                Instantiate(ball, new Vector3(Random.Range(transform.position.x - 30f, transform.position.x + 30f), transform.position.z, transform.position.z), transform.rotation);
                nextTimeToSpawn = Time.time + timeBetweenSpawn;
            }
        }
    }
}
