using UnityEngine;
using System.Collections;

public class lista : MonoBehaviour
{
    public GameObject[] correto, falso;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "noitem")
        {
            correto[0].SetActive(true);
            falso[0].SetActive(false);
        }

        if (other.gameObject.tag == "item")
        {
            correto[1].SetActive(true);
            falso[1].SetActive(false);
        }
    }
}
