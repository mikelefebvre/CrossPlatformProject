using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager levelInstance = null;

    GameObject Player;

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

    public void spawnPlayer(int spawnLocation)
    {
        string spawnPointName = SceneManager.GetActiveScene().name + "_" + spawnLocation;

        //Find where player should be spawned
        Transform spawnPointTransform = GameObject.Find(spawnPointName).GetComponent<Transform>();

        Instantiate(Player, spawnPointTransform.position, spawnPointTransform.rotation);
    }

    public void MarioDeath()
    {

    }
}
