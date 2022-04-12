using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0 );

    private float startDelay = 1;
    private float repeatDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObjects", startDelay, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void spawnObjects()
    {
        Instantiate(objectPrefab, spawnPos, objectPrefab.transform.rotation);

    }
}
