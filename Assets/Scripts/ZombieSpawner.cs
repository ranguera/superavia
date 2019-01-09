using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombie;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 4.6f);
        InvokeRepeating("Spawn", 3.5f, 7.2f);
    }

    private void Spawn()
    {
        Instantiate(zombie, this.transform.position, Quaternion.identity);
    }
}
