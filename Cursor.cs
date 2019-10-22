using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour {

	public Texture cursorimg;
	// Use this for initialization
	void Start () 
	{
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		Vector3 mousePos = Input.mousePosition;
		Rect pos = new Rect (mousePos.x, Screen.height - mousePos.y, cursorimg.width, cursorimg.height);
		GUI.Label (pos, cursorimg);	
	}
}
