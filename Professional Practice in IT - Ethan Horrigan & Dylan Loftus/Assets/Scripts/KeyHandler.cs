using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHandler : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D node)
       {
           if (node.gameObject.tag == "PickUp")
           {
               node.gameObject.SetActive(false);
            Health.keysCollected++;
           }
       }
}
