using UnityEngine;
using System.Collections;

public class itemNormal : MonoBehaviour
{
    void Update ()
    {
        transform.Translate(0, -2f * Time.deltaTime, 0);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "chao")
        {
            Destroy(this.gameObject);
        }
    }
}
