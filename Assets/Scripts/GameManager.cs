using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager levelInstance = null;

    public int score = 0;
    public int coins = 0;

    void Awake()
    {
        if (!levelInstance)
        {
            levelInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    // Use this for initialization
    void Start () {
        score = 0;
        coins = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
