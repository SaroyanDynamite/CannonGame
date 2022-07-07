using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveFrom = new Vector3(-25.0f, -85.0f, 0.0f);
    private Vector3 moveTo = new Vector3(-25.0f, 85.0f, 0.0f);
    public float rotationSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get the Player to rotate between the moveFrom and moveTo vectors at the rate of rotationSpeed
        Quaternion from = Quaternion.Euler(this.moveFrom);
        Quaternion to = Quaternion.Euler(this.moveTo);

        float lerp = 0.5f * (1.0f + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.rotationSpeed));
        this.transform.localRotation = Quaternion.Lerp(from, to, lerp);
        //this.transform.localRotation = Quaternion.Lerp(from, to, 0);

    }
}
