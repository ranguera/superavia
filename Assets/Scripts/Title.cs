using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public GameObject avia;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Go());
        }
    }

    private IEnumerator Go()
    {
        GetComponent<AudioSource>().Play();
        avia.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Game");
    }
}
