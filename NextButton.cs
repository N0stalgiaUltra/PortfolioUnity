using UnityEngine;
using System.Collections;

public class NextButton : MonoBehaviour {

	public GameObject inst;
	public AudioSource audio;
	void OnMouseDown()
	{	
		inst.GetComponent<Instructions> ().posicao = 2;
		audio.Play ();
	}
}