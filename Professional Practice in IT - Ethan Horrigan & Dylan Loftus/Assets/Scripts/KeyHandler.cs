using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{
    public AudioClip collect;    // Add your Audi Clip Here;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = collect;
    }

    public void OnTriggerEnter2D(Collider2D node)
       {
           if (node.gameObject.tag == "PickUp")
           {
            node.gameObject.SetActive(false);
            Health.keysCollected++;
            GetComponent<AudioSource>().Play();
        }
       }
}
