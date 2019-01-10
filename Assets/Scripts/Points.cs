using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameObject points;
    public GameObject papa;

    public int p = 10;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 4f, 4f);    
    }

    private void Spawn()
    {
        GameObject go = (GameObject) Instantiate(points, this.transform.position, Quaternion.identity);
        go.transform.parent = papa.transform;
        go.GetComponent<TextMesh>().text = p.ToString();
        p += 10;
    }
}
