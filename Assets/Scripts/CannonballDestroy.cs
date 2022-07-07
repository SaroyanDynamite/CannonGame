using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SelfDestruct());
    }
   

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -1)
        {
            Destroy(gameObject);
        }
    }
}
