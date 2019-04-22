using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject highlight;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("MouseEnter");
        highlight.GetComponent<SpriteRenderer>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("MouseExit");
        highlight.GetComponent<SpriteRenderer>().enabled = false;
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
