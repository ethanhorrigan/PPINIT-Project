using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public static int keysCollected;
    public int keysNeeded;

    public Image[] keys;
    public Sprite fullKey;
    public Sprite emptyKey;


    public static int health = 3;
    public int healthLeft;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    void Start() {
        health = 3;
        keysCollected = 0;
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keys.Length; i++)
        {
            if(i < keysCollected)
            {
                keys[i].sprite = fullKey;
            }
            else
            {
                keys[i].sprite = emptyKey;
            }

            if(i < keysNeeded)
            {
                keys[i].enabled = true;
            } else
            {
                keys[i].enabled = false;
            }
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < healthLeft)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }

    }
}
