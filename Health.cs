using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour {

	 GameObject HP;
	// Use this for initialization
	void Start () 
	{
		HP = GameObject.FindGameObjectWithTag("HPText"); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			HP.GetComponent<PlayerHP> ().hp = 50;
			Destroy (gameObject);
		}
	}
}
