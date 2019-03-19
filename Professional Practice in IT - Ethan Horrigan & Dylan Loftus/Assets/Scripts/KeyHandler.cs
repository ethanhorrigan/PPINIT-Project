using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{

    public GameObject player;
    public GameObject key;
    PolygonCollider2D coll;
    public string keyId;

    // Start is called before the first frame update
    void Start()
    {
        SetPlayer(player);
        Debug.Log(player.tag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPlayer(GameObject p)
    {
        player = p;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" && keyId == "Hubert")
        {
           Debug.Log("PLAYER 1 KEY COLLIDED");
            key.SetActive(false);
            Debug.Log("REEEEEE");
        }

        if (collision.gameObject.tag == "Player2" && keyId == "Eugene")
        {
            Debug.Log("PLAYER 2 KEY COLLIDED");
            key.SetActive(false);
        }


    }
}
