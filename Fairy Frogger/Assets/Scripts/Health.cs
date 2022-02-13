using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	public int currentHealth = 3;
    public Text HealthText;

	void Start()
	{
		HealthText.text = currentHealth.ToString();
	}
 public void Damage()
 {
     currentHealth -= 1;
    
 }

}

