using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]
public class Movimento : MonoBehaviour {

	public float VelocidadeRot = 450;
	public float VelocidadeAndando = 20;
	public float VelocidadeCorrendo = 30;
	
	private Quaternion targetRotation;

	public GameObject ammo;
	public GameObject arma;
	public GameObject frente;

	public AudioClip blink; 
	public AudioSource esteirasom;
	bool movimento;

	//private CharacterController controller;
	private Camera cam;

	void Start () 
	{
		//controller = GetComponent<CharacterController> ();
		cam = Camera.main;
		arma = GameObject.FindGameObjectWithTag("Arma");

	}
	

	void Update () 
	{


		MovMouse ();
		//MovWASD ();
	}

	void MovMouse()
	{
		if(movimento = true)
		{
			Vector3 MousePos = Input.mousePosition;
			MousePos = cam.ScreenToWorldPoint (new Vector3 (MousePos.x, MousePos.y, cam.transform.position.y - transform.position.y));
			targetRotation = Quaternion.LookRotation (MousePos - new Vector3 (transform.position.x, 0, transform.position.z));
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle (transform.eulerAngles.y, targetRotation.eulerAngles.y, VelocidadeRot * Time.deltaTime);


			Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
			Vector3 motion = input;
			motion *= (Mathf.Abs (input.x) == 1 && Mathf.Abs (input.z) == 1)?.7f:1; 
			motion *= (Input.GetButton ("Run"))?VelocidadeCorrendo : VelocidadeAndando;
			motion += Vector3.up * -8;
			//controller.Move(motion * Time.deltaTime);
			transform.Translate(new Vector3(Input.GetAxis("Horizontal") *8* Time.deltaTime, 0, Input.GetAxis("Vertical") *6* Time.deltaTime));

		}

	}

	void MovWASD()
	{
		Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		
		if (input != Vector3.zero) // quando estver parado,o cubo pode rotacionar
		{
			targetRotation = Quaternion.LookRotation(input);
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y,targetRotation.eulerAngles.y,VelocidadeRot * Time.deltaTime);
		}
		
		Vector3 motion = input;
		motion *=(Mathf.Abs (input.x) == 1 && Mathf.Abs (input.z) == 1)?.7f:1; 
		motion *= (Input.GetButton ("Run"))?VelocidadeCorrendo : VelocidadeAndando;
		motion += Vector3.up * -8;
		//controller.Move (motion * Time.deltaTime);
		transform.Translate(new Vector3(Input.GetAxis("Horizontal") *3* Time.deltaTime, 0, Input.GetAxis("Vertical") *3* Time.deltaTime));

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "ammo") 
		{
			Debug.Log("ok");
			Destroy(other.gameObject);
			arma.GetComponent<Arma>().municaototal +=10;
		}

		if(other.gameObject.tag == "wrench")
		{
			Debug.Log ("DSA");
			Destroy(other.gameObject);
			frente.GetComponent<ActionButton001>().livre = true;
			audio.Play();
		}

	}


}
