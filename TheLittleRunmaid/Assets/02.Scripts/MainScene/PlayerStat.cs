using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public static PlayerStat instance;
    const byte maxHP = 5; // 하트의 개수, 체력
    byte currentHP;
    uint coin; // 보유 코인
    uint star; // 보유 별 (상점에서 하트로 교환 가능)

    void Start()
    {
        instance = this;
        currentHP = maxHP;
        coin = 0;
        star = 0;
    }

    void Update()
    {
        
    }
}
