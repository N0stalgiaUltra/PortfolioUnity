using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public float contador =  5f;
	public float velocity = 3f;
	public bool moving = false;
	public bool Slow,Turbo,up,down;
	public float contadorSlow,contadorTurbo;
	GameObject meteoros,health,slow,turbo;

	// Use this for initialization
	void Start () 
	{
		meteoros = GameObject.FindGameObjectWithTag("Meteoros");
		health = GameObject.FindGameObjectWithTag("Health");
		slow = GameObject.FindGameObjectWithTag("Slow");
		turbo = GameObject.FindGameObjectWithTag ("Turbo");
		Slow = false;
		Turbo = false;
		down = false;
		up = false;
	}



	// Update is called once per frame
	void Update () 
	{
		//contador += Time.deltaTime;

		//transform.Translate (0.1f * Time.time,0,0);

		if(Slow == true)
		{
			contadorSlow += Time.deltaTime;
			velocity = 1f;

			if(contadorSlow >= 15f)
			{
				Slow = false;
				contadorSlow = 0;
			}
		}
		
		if(Turbo == true)
		{
			contadorTurbo += Time.deltaTime;
			velocity = 5f;
			
			if(contadorTurbo >= 15f)
			{
				Turbo = false;
				contadorTurbo = 0;
			}
		}

		transform.Translate(new Vector3(0, Input.GetAxis("Vertical") *3* Time.deltaTime,0 ));


		
		if(up == true)
			transform.Translate (0,-velocity * Time.deltaTime,0);//cima

		else if(down == true)
			transform.Translate (0,velocity * Time.deltaTime,0);//baixo

	}
	public void buttonDown()
	{
		down = true;
	}

	public void buttonUp()
	{
		down = false;
	}
	public void CimaDown()
	{
		
		up = true;
		
	}
	
	public void CimaUp()
	{
		up = false;
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Meteoros")
		{
			Destroy(meteoros);
			GetComponent<PlayerHP>().hp -=25;
			Debug.Log ("pegou");
		}
	}
}

