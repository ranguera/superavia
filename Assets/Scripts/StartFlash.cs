using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFlash : MonoBehaviour
{
    private Text t;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
        InvokeRepeating("Flash", 0f, 1f);
    }

    private void Flash()
    {
        t.enabled = !t.enabled;
    }
}
