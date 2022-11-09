using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class LogoEffect : MonoBehaviour
{

    void Start()
    {
        transform.DOLocalMoveY(150, 2.0f).SetEase(Ease.OutBounce);
    }

    void Update()
    {

    }

}
