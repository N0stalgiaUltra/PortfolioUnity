using UnityEngine;
using System.Collections;


public class RyuSeiKen : MonoBehaviour {

	public Transform[] RyuSpawns;
	public GameObject meteoros;
	public float tempoSpawn,tempovelo,velo;
	public float tempo;
	// Use this for initialization
	void Start () 
	{
		//tempovelo = 5f;
		tempoSpawn = 5f;

		//velo = 4f;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		int temp = Random.Range(0,RyuSpawns.Length);
		int temp2 = Random.Range(0,RyuSpawns.Length);
		int temp3 = Random.Range(0,RyuSpawns.Length);
		int temp4 = Random.Range(0,RyuSpawns.Length);

		tempo += Time.deltaTime;
		tempovelo -= Time.deltaTime;

		//transform.Translate (0,0, -2 * Time.deltaTime);

		if(tempo > tempoSpawn)
		{
			Instantiate(meteoros, RyuSpawns[temp].position, RyuSpawns[temp].rotation);
			Instantiate(meteoros,RyuSpawns[temp2].position,RyuSpawns[temp2].rotation);
			tempo = 0;
		}



		if(tempovelo == 0)
		{
			velo ++;
		}
	}
}
