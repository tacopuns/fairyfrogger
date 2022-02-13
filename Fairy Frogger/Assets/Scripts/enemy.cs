using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemy : MonoBehaviour
{
    
	public Rigidbody2D rigidbody2d;
	public float minSpeed = 8f;
	public float maxSpeed = 12f;
	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () 
	{
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rigidbody2d.MovePosition(rigidbody2d.position + forward * Time.fixedDeltaTime * speed);
	}
	private void OnTriggerEnter2D(Collider2D collision)
     {
         if (collision.transform.name == "Player")
         {
             collision.GetComponent<PlayerController>().Damage();
         }
     }
}