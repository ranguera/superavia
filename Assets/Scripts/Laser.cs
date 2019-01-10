using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private SoundEffects sfx;

    // Start is called before the first frame update
    void Start()
    {
        sfx = GameObject.Find("SoundEffects").GetComponent<SoundEffects>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.right * Time.deltaTime * 10f);

        if (this.transform.position.x >= 50f)
            Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name.Contains("Zombie"))
        {
            sfx.Hit();
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
