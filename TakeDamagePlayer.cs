using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TakeDamagePlayer : MonoBehaviour {

	public float health; //HP do inimigo
	public GameObject hpGUI;

	void Start()
	{
	
	}

	void Update()
	{	
		hpGUI.guiText.text = "HP: " + health + "%";

		if(health <= 0)
		{
			Destroy(gameObject);
			Application.LoadLevel("game-over");
		}

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Enemy") 
		{
			health--;		
		}
	}
}

