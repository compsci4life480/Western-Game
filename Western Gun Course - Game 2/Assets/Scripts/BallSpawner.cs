using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject ball;
    public float timeBetweenSpawn;
    public float timeToStart;
    float nextTimeToSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.unscaledTime> timeToStart)
        {
            if (Time.time >= nextTimeToSpawn)
            {
                Instantiate(ball, new Vector3(Random.Range(transform.position.x - 50f, transform.position.x + 50f), transform.position.z, transform.position.z), transform.rotation);
                nextTimeToSpawn = Time.time + timeBetweenSpawn;
            }
        }
    }
}
