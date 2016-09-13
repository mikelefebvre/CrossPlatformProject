using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    GameObject Player;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(!Player)
        {
            Debug.Log("Not Mario");
            Player = GameObject.FindGameObjectWithTag("Player");

        }

        transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
	}
}
