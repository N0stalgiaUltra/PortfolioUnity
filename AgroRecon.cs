using UnityEngine;
using System.Collections;

public class AgroRecon : MonoBehaviour {

	public GameObject player,enemy,explosion;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			enemy.GetComponent<ExplosaoEnemy>().recon = true;
			explosion.SetActive(true);
		}
	}
}
