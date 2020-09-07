using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

//Created By Wolfgang Gross
//CIS 491, Fall 2020


//Attach to player
public class PlayerEnterTrigger : MonoBehaviour
{
   // public Text textbox;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            //set the textbox text to "You Win!"
            //textbox.text = "You Win!";
            ScoreManager.score++;
        }
    }

}
