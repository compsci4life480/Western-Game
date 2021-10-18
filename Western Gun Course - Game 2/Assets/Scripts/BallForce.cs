using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    public GameObject target;
    private Vector3 dir;
    public float speed;
    public float velocity;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        dir = target.transform.position - transform.position;
       // dir = dir.normalized;
        rb = gameObject.GetComponent<Rigidbody>();
        //rb.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * speed);

    }

    // Update is called once per frame
    void Update()
    {
        //dir = target.transform.position - transform.position;
        rb.velocity *= velocity;
        rb.AddForce(dir.normalized * speed);
    }
}
