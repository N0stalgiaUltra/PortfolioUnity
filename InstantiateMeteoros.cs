using UnityEngine;
using System.Collections;

public class InstantiateMeteoros : MonoBehaviour 
{
	public Transform[] spawns;
	public GameObject meteoro;
	public float timer,timer2;
	public int qtd = 1;

	// Use this for initialization
	void Start () 
	{
		GameObject.FindGameObjectWithTag("Meteoro");
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;

		if(timer2 > 20)
		{
			qtd++;
			timer2 = 0;
		}

		if(timer > 5f)
		{
			timer = 0;

			for(int i = 0;i < qtd;i++)
			{
				int R = Random.Range(0,spawns.Length);
				Instantiate(meteoro,spawns[R].transform.position,spawns[R].transform.rotation);
			}
		}
	}

}
