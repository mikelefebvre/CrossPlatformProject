using UnityEngine;
using System.Collections;

public class Level2 : MonoBehaviour {
    // Use this for initialization
    public GameObject spawn;

    void Awake()
    {

    }
    void Start () {
        GameManager.levelInstance.spawnPlayer(spawn);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
