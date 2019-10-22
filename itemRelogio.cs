using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class itemRelogio : MonoBehaviour
{
    public AudioSource blink;
    public AudioClip som;

    void Update ()
    {
        transform.Translate(0, -2f * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            blink.Play();
            Destroy(this.gameObject,0.1f);
            Tempo.tempo += 5;
        }

        if (other.gameObject.tag == "chao")
        {
            Destroy(this.gameObject);
        }
    }
}
