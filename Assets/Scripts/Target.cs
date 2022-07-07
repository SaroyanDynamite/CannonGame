using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    GameManagerScript gameManager;
    int addThis = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TargetHit()
    {
        gameManager.AddToScore(addThis);
    }

    private void OnTriggerEnter(Collider other)
    {
        TargetHit();
    }
   }
