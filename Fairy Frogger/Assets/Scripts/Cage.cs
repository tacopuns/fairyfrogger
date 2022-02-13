using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cage : MonoBehaviour
{
 public Text WinText;
 public bool gameOver = false;
 
 void OnCollisionEnter2D (Collision2D coll) 
 {
    if(coll.collider.CompareTag("Player"))
    {
        WinText.text = "You Win";
         gameOver = true;
    
    }
 }
}
