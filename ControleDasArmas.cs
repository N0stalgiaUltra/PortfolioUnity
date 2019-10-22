using UnityEngine;
using System.Collections;

public class ControleDasArmas : MonoBehaviour {
	
	public GameObject[] armas;
	int index = 0;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		for (int i = 0; i < armas.Length; i++)
		{
			if (i == index)
			{
				armas[i].SetActive (true);
			}
			
			else
			{
				armas[i].SetActive(false);
			}
		}
		
		if(Input.GetKeyDown(KeyCode.Q))
		{
			index ++;
		}
		
		if (index >= armas.Length)
			index = 0;
		
	}
	
	
}
