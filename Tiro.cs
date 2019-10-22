using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour 
{
	public float velocidade;
	

	// Use this for initialization
	void Start () 
	{
		velocidade = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (0,0,velocidade * Time.deltaTime);	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			other.GetComponent<TakeDamage>().health -=1;
			Destroy(gameObject);
		}
		if(other.gameObject.tag == "parede")
		{
			Destroy(gameObject);
		}
	}


}
