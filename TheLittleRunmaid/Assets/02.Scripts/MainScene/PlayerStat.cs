using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    // public static PlayerStat instance;
    uint coin; // 보유 코인
    uint star; // 보유 별 (상점에서 하트로 교환 가능)
    public static int CurrentHP {get; set;}
    public static int MaxHP {get;set;}
    void Awake()
    {
        MaxHP = 5;
        CurrentHP = MaxHP;
        coin = 0;
        star = 0;
    }

    void Update()
    {
        
    }
}
