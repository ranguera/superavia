using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Avia : MonoBehaviour
{
    public Text score;
    public SoundEffects sfx;
    public Image pan;
    public GameObject cap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            cap.transform.Rotate(Vector3.forward, 1f);
        if (Input.GetKey(KeyCode.DownArrow))
            cap.transform.Rotate(Vector3.forward, -1f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("Points"))
        {
            score.text = col.GetComponent<TextMesh>().text;
            if (System.Convert.ToInt16(score.text) < 100)
            {
                sfx.Points();
                Destroy(col.gameObject);
            }
            else
            {
                StartCoroutine(Transition());
            }
        }
    }

    private IEnumerator Transition()
    {
        Color c = pan.color;
        while(pan.color.a < 1f)
        {
            c.a += .02f;
            pan.color = c;
            yield return null;
        }

        SceneManager.LoadScene("Game2");
    }
}
