using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class LogoEffect : MonoBehaviour
{

    [SerializeField]
    private AnimationCurve animationCurve;
    void Start()
    {
        //transform.DOLocalMoveY(150, 5.0f).SetEase(Ease.OutElastic);
        transform.DOLocalMoveY(150, 3.0f).SetEase(animationCurve);
    }
        

    void Update()
    {

    }

}
