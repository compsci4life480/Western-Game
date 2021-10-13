using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public float impactForce = 30f;
    //public float fireRate = 10f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffectGround;
    public GameObject impactEffectObject;

    public float fireCooldown;
    float nextTimeToFire = 0f;
    public Vector3 upRecoil;
    Vector3 originalRotation;

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
        //GameObject impactGO = new GameObject();
        muzzleFlash.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            GameObject impactGO;
            muzzleFlash.Play();
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }

            impactGO = Instantiate(impactEffectObject, hit.point, Quaternion.LookRotation(hit.normal));
            
            Destroy(impactGO, 2f);
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
}