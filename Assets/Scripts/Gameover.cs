using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    private Text t;
    private Color c;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
        c = t.color;
    }

    // Update is called once per frame
    void Update()
    {
        c.a = Mathf.PingPong(Time.time, 1f);
        t.color = c;
    }
}
