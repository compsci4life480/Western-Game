using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSpeedMatcher : MonoBehaviour
{

    private AudioSource ambience;
    // Start is called before the first frame update
    void Start()
    {
        ambience = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ambience.pitch = Time.timeScale;
    }
}
