using UnityEngine;
using System.Collections;

public class TiroController : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Vector2 NovaPosicao = new Vector2(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y + 3 * Time.deltaTime);
        GetComponent<Transform>().position = NovaPosicao;
        if (NovaPosicao.y > 10)
        {
            Destroy(transform.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Destroy(transform.gameObject);
    }

}
