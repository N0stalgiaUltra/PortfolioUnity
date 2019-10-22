using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour 
{	
	public Camera cam;
	public Transform pag1, pag2, menu;
	public int posicao;
	public AudioSource audio;
	void Start()
	{
		posicao = 3;
	}
	void Update()
	{
		if(posicao == 1)
		cam.transform.position = Vector3.Lerp(cam.transform.position, pag1.transform.position, 4 * Time.deltaTime);

		if(posicao == 2)
		cam.transform.position = Vector3.Lerp(cam.transform.position, pag2.transform.position, 4 * Time.deltaTime);

		if(posicao == 3)
		cam.transform.position = Vector3.Lerp(cam.transform.position, menu.transform.position, 4 * Time.deltaTime);
	}
	void OnMouseDown()
	{
		posicao = 1;
		audio.Play ();
	}
}