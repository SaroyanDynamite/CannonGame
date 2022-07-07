using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    int currentScore;
    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToScore(int addAmount)
    {
        currentScore += addAmount;
        Debug.Log(currentScore);
    }

    void SetCountText()
    {
        countText.text = "Count: " + currentScore.ToString();
        /*if (count >= 12)
        {
            winTextObject.SetActive(true);
        }*/
    }
}
