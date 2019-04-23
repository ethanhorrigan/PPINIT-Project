using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PortalHandler : MonoBehaviour
{
    public GameObject must3keys;


    // Start is called before the first frame update
    void Start()
    {
        must3keys.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with portal");
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            if(Health.keysCollected == 3)
            {
                SceneManager.LoadScene("LevelSelector");
            }
            else
            {
                must3keys.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
}
