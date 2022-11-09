using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void ExitGame() // Intro 씬 종료하기 버튼
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

}