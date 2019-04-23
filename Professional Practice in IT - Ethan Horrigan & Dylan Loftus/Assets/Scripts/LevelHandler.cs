using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image highlight;

    public void OnPointerEnter(PointerEventData eventData)
    {

        Debug.Log("MouseEnter");
        highlight.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("MouseExit");
        highlight.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
