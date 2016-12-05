using UnityEngine;
using System.Collections;

public class SpawnInimigo : MonoBehaviour {

    public int QuantidadeInimigos;
    public GameObject InimigosObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < QuantidadeInimigos; i++)
        {
            Instantiate(InimigosObj, new Vector2(-10 -2*i, 7.29f), Quaternion.identity);
        }
        QuantidadeInimigos = 0;
    }
}
