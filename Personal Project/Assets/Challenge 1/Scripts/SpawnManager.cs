using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] planePrefabs;

    private float spawnPosZ = 50;
    private float spawnRangeX = 40;
    //private float spawnLimitXLeft = -40;
    //private float spawnLimitXRight = 40;


    private float startDelay = 2;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPlane", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomPlane ()
    {
        int planeIndex = Random.Range(0, planePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(planePrefabs[planeIndex], spawnPos, planePrefabs[planeIndex].transform.rotation);
    }
}





//int planeIndex = Random.Range(0, planePrefabs.Length);
//Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosZ, 0);
//Invoke("SpawnRandomPlane", Random.Range(3, 5));

     //if (Input.GetKeyDown(KeyCode.S))
       // {
            //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
//int planeIndex = Random.Range(0, planePrefabs.Length);
//Instantiate(planePrefabs[planeIndex], spawnPos,
//planePrefabs[planeIndex].transform.rotation);
       // }