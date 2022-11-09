using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    public Image[] Heart;
    public Sprite Back, Front;

    private void Awake()
    {
        if (PlayerStat.MaxHP != Heart.Length) Debug.LogWarning("HP UI 개수 이슈 : " + PlayerStat.MaxHP +"-"+ Heart.Length);
 
        //Front 이미지 초기화
        for (int i = 0; i < PlayerStat.MaxHP; i++)
            if (PlayerStat.CurrentHP > i)
            {
                Heart[i].sprite = Front;
            }
    }

    public void SetHp(int val)
    {
        PlayerStat.CurrentHP += val;
        //Hp가 0밑으로 내려가면 0으로 고정하고, Hp_Max를 초과하려고 하면 Hp_Max로 고정함.
        PlayerStat.CurrentHP = Mathf.Clamp(PlayerStat.CurrentHP, 0, PlayerStat.MaxHP);

        //Front 이미지 모두 제거
        for (int i = 0; i < PlayerStat.MaxHP; i++)
            Heart[i].sprite = Back;

        //Front 이미지 그리기
        for (int i = 0; i < PlayerStat.MaxHP; i++)
            if (PlayerStat.CurrentHP > i)
            {
                Heart[i].sprite = Front;
            }
    }
}
