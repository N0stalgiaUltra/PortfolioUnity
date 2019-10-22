using UnityEngine;
using System.Collections;

public class backButton2 : MonoBehaviour
{	public AudioSource audio;
	public GameObject inst;
	void OnMouseDown()
	{	
		audio.Play ();
		inst.GetComponent<Instructions>().posicao = 1;
	}
} 