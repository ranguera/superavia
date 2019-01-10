using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSoundEnd : MonoBehaviour
{
    public AudioClip end;
    public AudioClip matrix;

    private AudioSource asrc;

    // Start is called before the first frame update
    void Start()
    {
        asrc = GetComponent<AudioSource>();
        asrc.PlayOneShot(end);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            asrc.Stop();
            asrc.PlayOneShot(matrix);
        }
    }
}
