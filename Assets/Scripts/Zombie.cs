using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = (Input.GetKey(KeyCode.RightArrow)) ? 4f : 0f;
        this.transform.Translate(Vector3.left * (5f+x) * Time.deltaTime);

        if (this.transform.position.x < -12f)
            Destroy(this.gameObject);
    }
}
