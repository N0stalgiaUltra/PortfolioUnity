using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour
{
    public bool colidindo_direita = false;
    public bool colidindo_esquerda = false;
    float velocidade = 5f;
	void Update ()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * velocidade * Time.deltaTime, 0));
	}

}
