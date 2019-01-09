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

    public GameObject sprite;

    private bool jumping;
    private Vector3 base_pos;
    private Vector3 jump_vector;

    // Start is called before the first frame update
    void Start()
    {
        this.base_pos = this.sprite.transform.position;
        this.jump_vector = base_pos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.moving1.transform.Translate(Vector3.left * sp1 * Time.deltaTime);
            this.moving2.transform.Translate(Vector3.left * sp2 * Time.deltaTime);
            this.moving3.transform.Translate(Vector3.left * sp3 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (!this.jumping)
            {
                jumping = true;
                StartCoroutine(Jump());
            }
        }
    }

    private IEnumerator Jump()
    {
        while(this.sprite.transform.position.y < 1f)
        {
            this.jump_vector.y += Time.deltaTime * 10f;
            this.sprite.transform.position = this.jump_vector;
            yield return null;
        }

        while(this.sprite.transform.position.y >= base_pos.y)
        {
            this.jump_vector.y -= Time.deltaTime * 10f;
            this.sprite.transform.position = this.jump_vector;
            yield return null;
        }

        this.sprite.transform.position = base_pos;
        this.jumping = false;
    }
}
