using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class LevelHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image highlight;
    public int level;
    public Button LevelButton;
    private string SelectLevel;

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
        SelectLevel = "Level_" + level + "";
        LevelButton.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        switch(level)
        {
            case 1:
                SceneManager.LoadScene(SelectLevel);
                break;
            case 2:
                SceneManager.LoadScene(SelectLevel);
                break;
            case 3:
                SceneManager.LoadScene(SelectLevel);
                break;
            case 4:
                SceneManager.LoadScene(SelectLevel);
                break;
            case 5:
                SceneManager.LoadScene(SelectLevel);
                break;
            case 6:
                SceneManager.LoadScene(SelectLevel);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
