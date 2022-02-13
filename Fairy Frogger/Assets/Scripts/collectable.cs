using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public GameObject points;

    public void OnTriggerEnter2D(Collider2D other)
    {
    
        {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
            {
            controller.ChangeScore(1);
            Destroy(gameObject);
            
            }
        }
    }

}