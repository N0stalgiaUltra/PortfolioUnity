using UnityEngine;
using System.Collections;

public class HP : MonoBehaviour {

	public float health; 

	void Update()
	{	
		if(health <= 0)
		{
			Destroy(gameObject);
		}
	}
}

