using UnityEngine;
using System.Collections;

public class BrickSpecial : MonoBehaviour {

    int hit = 0;
    public GameObject player;
    public GameObject coins;
    public GameObject afterDone;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {

        if(coll.gameObject.tag == "Player")
        {
            if(hit <= 7)
            {
                Instantiate(coins, transform.position, transform.rotation);
                hit++;
            }
            else if(hit >= 7)
            {
                Instantiate(coins, transform.position, transform.rotation);
                Destroy(gameObject);
                Instantiate(afterDone, transform.position, transform.rotation);
            }
        }
    }
}
