using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float cubeTransformX;
    private float cubeTransformY;
    private Vector3 moveFrom;
    private Vector3 moveTo;
    //public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cubeTransformX = GetComponent<Transform>().position.x;
        cubeTransformY = GetComponent<Transform>().position.y;
        //private float cubeX = this.gameObject.transform.position.x;
        //private float cubeZ = cube.transform.position.z;

        //private Vector3 moveFrom = new Vector3(cubeX, -85.0f, cubeZ);
        //private Vector3 moveTo = new Vector3(cubeX, 85.0f, cubeZ);
    }

    // Update is called once per frame
    void Update() 
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }





}