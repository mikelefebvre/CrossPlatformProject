using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager levelInstance = null;

    public GameObject Player;

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
            DestroyImmediate(gameObject);
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

    public void spawnPlayer(GameObject startSpawn)
    {
       Instantiate(Player, startSpawn.transform.position, startSpawn.transform.rotation);
    }

    public void MarioDeath(GameObject player, int scenetoStart)
    {
        Destroy(player);
        SceneManager.LoadScene(scenetoStart);
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }
}
