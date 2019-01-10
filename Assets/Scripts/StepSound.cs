using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour
{
    public AudioClip step1;
    public AudioClip step2;


    private AudioSource asrc;
    private bool running;

    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
        InvokeRepeating("Step", 0f, .23f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            running = true;
        else
            running = false;
    }
    
    private void Step()
    {
        if (running)
        {
            if(Random.value < .5f)
                asrc.PlayOneShot(step1);
            else
                asrc.PlayOneShot(step2);
        }
    }
}
