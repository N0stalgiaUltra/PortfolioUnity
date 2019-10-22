using UnityEngine;
using System.Collections;

public class Lanterna : MonoBehaviour {

	public GameObject lanterna;
	public bool ligada = false;
	public AudioSource On;
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!ligada)
		{
			lanterna.SetActive(true);
		}
		else
		{
			lanterna.SetActive(false);
		}
		if (Input.GetKeyDown(KeyCode.E)) 
		{
			ligada = !ligada;
			On.Play();
		} 
	}
}