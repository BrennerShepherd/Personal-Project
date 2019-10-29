using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public GameObject projectilePrefab;
    private float xRange = 40;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < -40 )
       {
           transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 40)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // get the user's vertical input
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        
    }
}
