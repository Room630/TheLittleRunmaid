using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void ToIntro() // Intro ������
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene("IntroScene");
    }

    public void ToChapter() // Chapter Selection ������
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene("ChapterSelectionScene");
    }
    
    public void ToCh1Stage() // Chapter 1 - Stage Selection ������
    {
        Debug.Log("�ε�");
        SceneManager.LoadScene("StageSelectionScene");
    }

    public void Exit() // Intro �� �����ϱ� ��ư
    {
        Debug.Log("���� ����");
        Application.Quit();
    }

}