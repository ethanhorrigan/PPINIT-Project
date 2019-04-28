using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image highlight;
    public Button LevelButton;
    public int LevelID;
    private string LevelSelection;
    

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
        LevelSelection = "Level_"+LevelID+"";
        LevelButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void TaskOnClick() {
            SceneManager.LoadScene(LevelSelection);
        }
    
}
