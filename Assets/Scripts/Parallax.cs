using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float sp1 = 1f;
    public float sp2 = 2f;
    public float sp3 = 3f;

    public GameObject moving1;
    public GameObject moving2;
    public GameObject moving3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.moving1.transform.Translate(Vector3.left * sp1 * Time.deltaTime);
        this.moving2.transform.Translate(Vector3.left * sp2 * Time.deltaTime);
        this.moving3.transform.Translate(Vector3.left * sp3 * Time.deltaTime);
    }
}
