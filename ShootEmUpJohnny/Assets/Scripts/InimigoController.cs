using UnityEngine;
using System.Collections;

public class InimigoController : MonoBehaviour {

    private float velocidadeInimigo;

	// Use this for initialization
	void Start () {
        velocidadeInimigo = 3;
	}

    // Update is called once per frame
    void Update()
    {

        Vector2 NovaPosicao = new Vector2(GetComponent<Transform>().position.x + velocidadeInimigo * Time.deltaTime, GetComponent<Transform>().position.y);
        
        if (NovaPosicao.x > 10)
        {
            NovaPosicao = new Vector2(-10, GetComponent<Transform>().position.y - 0.8f);

        }
        GetComponent<Transform>().position = NovaPosicao;
    }

}

