using UnityEngine;
using System.Collections;

public class Turbo : MonoBehaviour {

	 GameObject player;
	// Use this for initialization
	void Start () 
	{		
		player = GameObject.FindGameObjectWithTag("Player"); 

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			player.GetComponent<Movement>().Turbo = true;
		}
	}
}
