using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHP : MonoBehaviour 
{
	public  int hp;
	public GameObject Player,faiscas,ponto,gameover,score,back,spawns,powerup;
	public bool morreu = false;
	Text text;
	public AudioSource som;

	// Use this for initialization
	void Start () 
	{
		text = GetComponent<Text>();
		hp = 50;
	}
	
	// Update is called once per frame
	void Update () 
	{



		text.text = "Health:" + hp;
		if (hp > 50)
			hp = 50;


		if(hp > 0)
		{
			Time.timeScale = 1;
			Player.GetComponent<Movement>().velocity = 3f;

		}
		if(hp > 26)
		{
			faiscas.SetActive(false);
		}
		if(hp <= 26)
		{
			faiscas.SetActive(true);
			Player.GetComponent<Movement>().velocity = 1.5f;
		}
		if (hp == 0) 
		{
			morreu = true;
		}

		if(morreu)
		{
			score.GetComponent<BackgroundRun>().runnin = false;
			ScoreManager.scores.Highscore();
			//Destroy (Player);
			ponto.SetActive(true);
			gameover.SetActive(true);
			Player.SetActive(false);
			gameover.transform.position = Vector3.Lerp(gameover.transform.position,ponto.transform.position,9f * Time.deltaTime);
			som.Play();
			spawns.SetActive(false);
			powerup.SetActive(false);
			/*
			if(Vector3.Distance(gameover.transform.position,ponto.transform.position) < 0.1f)
			{
				Time.timeScale = 0;	
			}*/
		}


	
	}
}
