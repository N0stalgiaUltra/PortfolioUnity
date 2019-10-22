using UnityEngine;
using System.Collections;

public class pupsVelocity : MonoBehaviour 
{
	float velocity = 2f;
	
	void Update () 
	{
		transform.Translate (-velocity * Time.deltaTime, 0, 0);
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Destruidor")
		{
			Destroy(gameObject);
		}
	}
}