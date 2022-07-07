using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCannonball : MonoBehaviour
{
    public GameObject cannonball;
    public float launchVelocity = 700f;
    private float destroyDelay = 5.0f;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject cball = Instantiate(cannonball, transform.position, transform.rotation);
            cball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, 0, launchVelocity));
        }
        
    }

}
