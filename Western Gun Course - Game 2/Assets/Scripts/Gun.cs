using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    //public float fireRate = 10f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    //public GameObject impactEffectGround;
    //public GameObject impactEffectObject;

    public float fireCooldown;
    float nextTimeToFire = 0f;
    public Vector3 upRecoil;

    public Text score;
    int scoreNumb = 0;

    Vector3 originalRotation;



    private AudioSource gunshotSound;

    private void Start()
    {
        score.text = "0";
        gunshotSound = gameObject.GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + fireCooldown;
            Shoot();
            AddRecoil();
        }
        else if (Input.GetButtonUp("Fire1"))
            StopRecoil();
    }

    void Shoot()
    {
        gunshotSound.Play();
        //GameObject impactGO = new GameObject();
        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            //GameObject impactGO;
            muzzleFlash.Play();
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
                UpdateScore();
            };
        }
    }
    private void AddRecoil()
    {
        transform.localEulerAngles += upRecoil;
    }

    private void StopRecoil()
    {
        transform.localEulerAngles = originalRotation;
    }

    private void UpdateScore()
    {
        scoreNumb++;
        score.text = scoreNumb.ToString();
    }
}
