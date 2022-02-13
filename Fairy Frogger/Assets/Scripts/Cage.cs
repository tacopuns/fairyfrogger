using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cage : MonoBehaviour
{
 public Text WinText;
 public bool gameOver = false;

 public void OnTriggerEnter2D(Collider2D other)
    {
      {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
         {
            WinText.text = "You Win!";
            gameOver = true;
            
         }

      }
    }
            
}

