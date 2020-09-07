using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created By Wolfgang Gross
//CIS 491, Fall 2020


public class LoseOnFall : MonoBehaviour
{
    //public Text textbox;    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
