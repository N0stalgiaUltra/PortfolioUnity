using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

	public float tempoSpawn = 30f;
	public float velocity,tempo; 
	public Transform[] PSpawns;
	public GameObject[] powerups;


	void Update () 
	{
		tempo += Time.deltaTime;

		int spawns = Random.Range (0, PSpawns.Length);
		int powers = Random.Range (0, powerups.Length);

		if(tempo > tempoSpawn)
		{
			Instantiate(powerups[powers],PSpawns[spawns].position,PSpawns[spawns].rotation);
			tempo = 0;
		}


	}

}
