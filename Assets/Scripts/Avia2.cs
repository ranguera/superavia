using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Avia2 : MonoBehaviour
{
    public Text score;
    public Text gameover;
    public Text over;
    public SoundEffects sfx;
    public GameObject cap;
    public GameObject points;
    public GameObject ulleres;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            cap.transform.Rotate(Vector3.forward, 2f);
        if (Input.GetKey(KeyCode.DownArrow))
            cap.transform.Rotate(Vector3.forward, -2f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Animator>().enabled = true;
            over.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
            StartCoroutine(Gameover());

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("Points"))
        {
            score.text = col.GetComponent<TextMesh>().text;
            sfx.Points();
            Destroy(col.gameObject);
        }
    }

    private IEnumerator Gameover()
    {
        gameover.enabled = true;
        points.SetActive(true);
        ulleres.SetActive(true);
        yield return new WaitForSeconds(3f);
        gameover.enabled = false;
    }
}
