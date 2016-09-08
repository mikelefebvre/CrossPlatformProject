using UnityEngine;
using System.Collections;

public class TubeEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            coll.gameObject.SetActive(false);
            coll.gameObject.transform.position = GameObject.Find("EndSpawn").transform.position;
            coll.gameObject.SetActive(true);
        }
    }
}
