using UnityEngine;
using System.Collections;

public class AutomaticaCoroutine : MonoBehaviour {

	private int counter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton("Fire1"))		//quando segurar
		{
			StartCoroutine("DelayedShot",0.2f);//comeca o metodo DelayedShot como coroutine
		}
	}

	IEnumerator DelayedShot(float delay)
	{
		//espera o tempo definido por "Delay"
		yield return new WaitForSeconds(delay);
		//yield é um retorno de um valor,que garante que a funcao vai continuar 
		Debug.Log(counter);
		counter++;
		//para a Coroutine
		StopCoroutine("DelayedShot");
	}
}
