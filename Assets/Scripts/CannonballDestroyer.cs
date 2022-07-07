using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CannonballDestroyer : MonoBehaviour
{
    //public TextMeshProUGUI countText;
    //private int count;
    //public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //count = 0;
        //SetCountText();
    }

    /*void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        /*if (count >= 12)
        {
            winTextObject.SetActive(true);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cannonball"))
        {
            //count++;
            Destroy(other.gameObject);
            //SetCountText();
        }
    }
}
