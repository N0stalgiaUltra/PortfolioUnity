using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public  class RyuSeiKenMov : MonoBehaviour {

	GameObject hp;
	public float tempo = 5f;
	public  float velo = 4.5f;
	// Use this for initialization
	void Start () 
	{
		hp = GameObject.Find("HP");
		velo = 7.5f;
	}
	
	// Update is called once per frame
	void Update ()
	{	
		transform.Translate (-velo * Time.deltaTime,0,0);
		//Debug.Log ("velo");
		/*
		tempo -= Time.deltaTime;

		if(tempo <= 0)
		{
			velo ++;
		}*/
	}
	void OnCollisionEnter(Collision other)
	{
		/*
		if(other.gameObject.tag == "Player")
		{
			text.GetComponent<PlayerHP>().hp -=25;
			Destroy(gameObject);
			Debug.Log("pegou");

		}*/

		if(other.gameObject.tag == "Destruidor")
		{
			Destroy(gameObject);
			//Debug.Log("Destruiu");
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			hp.GetComponent<PlayerHP>().hp -=25;
			Destroy(gameObject);
			Debug.Log("pegou");
		}
	}
}

