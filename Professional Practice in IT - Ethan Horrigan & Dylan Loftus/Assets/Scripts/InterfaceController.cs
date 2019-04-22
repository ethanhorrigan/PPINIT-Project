using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterfaceController : MonoBehaviour
{

    public Button PlayButton;

    private string SelectLevelScene = "LevelSelector";
    
    private void Start()
    {
        PlayButton.onClick.AddListener(TaskOnClick);
    }

    private void TaskOnClick()
    {
        StartCoroutine(LoadScene());
    }

    private IEnumerator LoadScene()
    {
        //show animate out animation
        //animator.SetBool("animateOut", true);
        yield return new WaitForSeconds(1f);

        //load the scene we want
        SceneManager.LoadScene(SelectLevelScene);
    }
}


