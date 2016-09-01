using UnityEngine;
using System.Collections;

public class QBlock : MonoBehaviour {

    public GameObject coins;
    public GameObject QBlockAfter;
    public GameObject player;
    public GameObject flower;


    void qBlockHit(string qBlockName)
    {
        if (qBlockName == "UGQBlock")
        {
            Instantiate(flower, gameObject.transform.position, gameObject.transform.rotation);
            Debug.Log("Score added");
        }
        else
        {
            Instantiate(coins, gameObject.transform.position, gameObject.transform.rotation);

            Debug.Log("Score Added");
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            Debug.Log("Block Hit");
            qBlockHit(this.gameObject.name);
            Instantiate(QBlockAfter, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }

}
