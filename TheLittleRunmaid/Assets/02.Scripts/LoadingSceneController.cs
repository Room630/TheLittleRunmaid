using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneController : MonoBehaviour
{
    static string nextScene;
    [SerializeField]
    Image progressbar;

    /// <summary>
    /// 원하는 씬으로 넘어갈 때... 이 함수를 써주세요
    /// </summary>
    public static void LoadingScene(string sceneName, bool playLoadScene)
    {
        nextScene = sceneName;
        if(playLoadScene)
        {
            SceneManager.LoadScene("LoadingScene");
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
        
    }
    /// <summary>
    /// 인게임 전까지 Intro ~ Selection 화면에서의 씬 전환 함수입니다.
    /// </summary>
    public static void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    void Start()
    {
        StartCoroutine(LoadSceneProgress());
    }


    IEnumerator LoadSceneProgress()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false; // 씬의 로딩이 끝나면 자동으로 불러온 씬으로 이동할 것인지 여부

        float timer = 0f;
        while (!op.isDone)
        {
            yield return null;

            if (op.progress < 0.9f)
            {
                // progressbar.fillAmount = op.progress; // 현재 로딩 속도가 너무 빨라서 일단 뺏음
            }
            else
            {
                timer += Time.unscaledDeltaTime;
                progressbar.fillAmount = Mathf.Lerp(0.9f, 1f, timer);
                if (progressbar.fillAmount >= 1f)
                {
                    op.allowSceneActivation = true;
                    yield break;
                }
            }
        }

    }
}
