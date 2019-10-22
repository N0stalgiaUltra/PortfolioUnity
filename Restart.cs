using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public GameObject player,back,spawns,powerup,hp;

	void Update()
	{
	}

	void OnMouseDown()
	{
			Debug.Log("reco");
			Application.LoadLevel(Application.loadedLevel);
			ScoreManager.scores.Highscore();
			player.SetActive (true);
			spawns.SetActive (true);
			powerup.SetActive (true);
			Time.timeScale = 1;
			hp.GetComponent<PlayerHP> ().som.Stop();
	}

}
