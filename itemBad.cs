using UnityEngine;
using System.Collections;

public class itemBad : MonoBehaviour
{
    public AudioSource audio;
	void Update ()
    {
        transform.Translate(0, -2f * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            audio.Play();
            Destroy(this.gameObject,0.1f);
            Tempo.tempo -= 6f;
        }

        if (other.gameObject.tag == "chao")
        {
            Destroy(this.gameObject);
        }
    }
}
