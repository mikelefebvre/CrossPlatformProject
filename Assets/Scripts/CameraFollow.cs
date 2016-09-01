using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject Player;

	// Use this for initialization
	void Start () {
		print("Ali is awesome");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
	}
}
