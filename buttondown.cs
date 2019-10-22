using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttondown : MonoBehaviour {

	public GameObject player;


	void OnMouseDown()
	{
		player.GetComponent<Movement>().down = true;
		Debug.Log ("indo");
	}
	
}
