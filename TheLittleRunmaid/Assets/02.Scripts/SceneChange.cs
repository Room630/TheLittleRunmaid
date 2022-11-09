using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void ToIntro() // Intro 씬으로
    {
        Debug.Log("로딩");
        SceneManager.LoadScene("IntroScene");
    }

    public void ToChapter() // Chapter Selection 씬으로
    {
        Debug.Log("로딩");
        SceneManager.LoadScene("ChapterSelectionScene");
    }
    
    public void ToCh1Stage() // Chapter 1 - Stage Selection 씬으로
    {
        Debug.Log("로딩");
        SceneManager.LoadScene("StageSelectionScene");
    }

    public void Exit() // Intro 씬 종료하기 버튼
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

}