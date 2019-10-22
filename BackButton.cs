using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour 
{	public AudioSource audio;
	public GameObject inst;
	void OnMouseDown()
	{	
		inst.GetComponent<Instructions> ().posicao = 3;
		audio.Play ();
	}
}