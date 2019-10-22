using UnityEngine;
using System.Collections;

public class BackgroundRun : MonoBehaviour 
{
	public float speed = 0.5f;
	public bool runnin = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (runnin == true) 
		{
			float offset = Time.time * speed; 
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (0, offset);
			ScoreManager.score+=1;
		}

		if(runnin == false)
		{
			float offset = Time.time * speed; 
			GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (0, offset);
		}
	}
}
