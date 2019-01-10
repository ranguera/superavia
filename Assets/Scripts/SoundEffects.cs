using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip fire;
    public AudioClip hit;
    public AudioClip points;

    private AudioSource asr;

    // Start is called before the first frame update
    void Start()
    {
        this.asr = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            asr.PlayOneShot(jump);
        else if (Input.GetKeyDown(KeyCode.Z))
            asr.PlayOneShot(fire);
    }

    public void Hit()
    {
        asr.PlayOneShot(hit);
    }

    public void Points()
    {
        asr.PlayOneShot(points);
    }
}
