using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Felicitats : MonoBehaviour
{
    private Text t;

    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Text>();
        StartCoroutine(Feli());
    }

    private IEnumerator Feli()
    {
        yield return new WaitForSeconds(3f);
        t.text = "Felicitats !!";
        yield return new WaitForSeconds(3f);
        t.text = "Per   molts   anys... ";
        yield return new WaitForSeconds(3f);
        t.text = "100 !!!! ";
        yield return new WaitForSeconds(3f);
        t.text = "";
    }
}
