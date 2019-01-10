using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiggle : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 init;
    private float r;

    // Start is called before the first frame update
    void Start()
    {
        pos = Vector3.zero;
        init = this.transform.position;
        r = Random.Range(.4f, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey(KeyCode.RightArrow))
        {
            pos.y = Mathf.PingPong(2f * Time.time, r);
            this.transform.position = init + pos;
        }
    }
}
