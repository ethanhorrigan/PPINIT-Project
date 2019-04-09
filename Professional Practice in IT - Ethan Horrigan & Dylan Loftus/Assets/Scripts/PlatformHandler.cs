using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHandler : MonoBehaviour
{

    public GameObject player;
    public GameObject platform;
    public GameObject ground;
    PolygonCollider2D coll;
    public string platformId;

    // Start is called before the first frame update
    void Start()
    {
        SetPlayer(player);
        Debug.Log(player.tag);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x == 17.00063)
        {

        }
    }

    void SetPlayer(GameObject p)
    {
        player = p;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" && platformId == "Player2")
        {
           Debug.Log("PLAYER 1 COLLIDED");
            platform.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (collision.gameObject.tag == "Player2" && platformId == "Player1")
        {
            Debug.Log("PLAYER 2 COLLIDED");
            platform.GetComponent<BoxCollider2D>().enabled = false;
        }

        if (collision.gameObject.tag == "gTag1")
        {
            Debug.Log("ttttD");
            platform.GetComponent<BoxCollider2D>().enabled = true;
        }



    }

}
