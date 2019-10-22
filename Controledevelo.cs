using UnityEngine;
using System.Collections;

public  class Controledevelo : MonoBehaviour 
{
	public GameObject meteoro;
	public float contador;
	// Use this for initialization
	void Start () 
	{
		//meteoro = GameObject.FindGameObjectWithTag("Meteoro");
		contador = 6.4f;
		meteoro.GetComponent<RyuSeiKenMov> ().velo = 4.5f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//float velocidade = meteoro.GetComponent<RyuSeiKenMov>().velo;
		contador -= Time.deltaTime;
		//meteoro.transform.Translate(-4f * Time.deltaTime,0,0);

		if(contador <= 0)
		{
			meteoro.GetComponent<RyuSeiKenMov>().velo+=1; 	
			contador = 8.4f;
			Debug.Log("estaindo");
		}

	}
}
