using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    public GameObject target;
    private Vector3 dir;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        dir = target.transform.position - transform.position;
        dir = dir.normalized;

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(dir * force);
    }
}
