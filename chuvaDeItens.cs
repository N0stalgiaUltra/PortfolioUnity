using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class chuvaDeItens : MonoBehaviour {

    public Transform[] spawns;
    public GameObject[] itens;
    private float tempo = 2f;
    void Start ()
    {
	
	}
	
	void Update ()
    {
        tempo -= Time.deltaTime;

        if(tempo < 0)
        {
            int I = Random.Range(0, itens.Length);
            int S = Random.Range(0, spawns.Length);
            Instantiate(itens[I], spawns[S].transform.position, spawns[S].transform.rotation);
            tempo = 2f;
        }
       
	}
}
