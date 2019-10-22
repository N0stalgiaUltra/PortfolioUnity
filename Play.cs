using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour 
{	public AudioSource audio;
	void OnMouseDown()
	{	audio.Play ();
		Application.LoadLevel (1);
	}
}

