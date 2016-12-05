using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    private Transform PlayerTransform;
    private int velocidade;
    public GameObject Tiro;

	// Use this for initialization
	void Start () {
        PlayerTransform = GetComponent<Transform>();
        velocidade = 2;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float x = PlayerTransform.position.x - velocidade * Time.deltaTime;
            PlayerTransform.position = new Vector2(x, PlayerTransform.position.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            float x = PlayerTransform.position.x + velocidade * Time.deltaTime;
            PlayerTransform.position = new Vector2(x, PlayerTransform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Tiro, PlayerTransform.position, Quaternion.identity);
        }


    }
}
