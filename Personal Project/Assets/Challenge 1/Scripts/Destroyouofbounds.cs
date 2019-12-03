using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyouofbounds : MonoBehaviour
{
    public float topBounds = 100;
    public float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
