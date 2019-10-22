using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tempo : MonoBehaviour
{
    public static float tempo;
    Text text;

    void Start ()
    {
        tempo = 50;
        text = GetComponent<Text>();

    }

    void Update ()
    {
        tempo -= Time.deltaTime;
        text.text = "Time:" + tempo;

        if (tempo <= 0)
        {
            Debug.Log("perdeu");
        }
	}
}
