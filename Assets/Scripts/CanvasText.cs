using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasText : MonoBehaviour {

    public GameObject player;
    public Text CharacterBox;
    public Text ScoreBox;
    public Text CoinBox;

    string textCon;
    string coinCon;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        CharacterBox.text = GameObject.FindGameObjectWithTag("Player").name;

        textCon = GameManager.levelInstance.score.ToString("f0");
        ScoreBox.text = textCon;

        coinCon = GameManager.levelInstance.coins.ToString("f0");
        CoinBox.text = coinCon;
    }
}
