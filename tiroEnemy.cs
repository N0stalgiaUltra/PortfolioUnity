using UnityEngine;
using System.Collections;

public class tiroEnemy : MonoBehaviour {
	public float velocidade;
	
	
	// Use this for initialization
	void Start () 
	{
		//Destroy(gameObject,0.5f);
	}
	
	// Update is called once per frame
	void Update () 
	{

		transform.Translate (0,0,velocidade * Time.deltaTime);	
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			other.GetComponent<TakeDamagePlayer>().health -=25;
			Destroy(gameObject);
		}
		if(other.gameObject.tag == "parede")
		{
			Destroy(gameObject);
		}
	}
}
