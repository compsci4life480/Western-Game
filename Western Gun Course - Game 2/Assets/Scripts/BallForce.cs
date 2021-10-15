using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    public GameObject target;
    private Vector3 dir;
    public float force;
    public float velocity;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        dir = target.transform.position - transform.position;
        dir = dir.normalized;
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity *= velocity;
        rb.AddForce(dir * force);
    }
}
