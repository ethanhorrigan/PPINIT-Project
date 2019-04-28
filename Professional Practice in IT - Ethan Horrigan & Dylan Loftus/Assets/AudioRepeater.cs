using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRepeater : MonoBehaviour
{
    /*
     * Keep Background Music playing throughout scenes.
     */
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
