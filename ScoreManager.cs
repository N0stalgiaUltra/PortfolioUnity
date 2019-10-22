using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour 
{
	public static ScoreManager scores;
	public static int score;
	int highscore;

	Text text;
	public Text hstext;

	// Use this for initialization
	void Awake () 
	{
		text = GetComponent<Text>();
		score = 0;
		highscore = PlayerPrefs.GetInt ("Highscore");
		scores = this;
	}
	
	// Update is called once per frame
	void Update () 
	{

		text.text = "Score:" + score;
		hstext.text = "Highscore:" + highscore;
	}

	public void Highscore()
	{
		if(score > highscore)
		{
			//Debug.Log("HS");
			PlayerPrefs.SetInt("Highscore",score);
			Debug.Log ("setou");
		}
	}
}
