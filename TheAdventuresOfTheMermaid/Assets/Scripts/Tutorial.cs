using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 
/// 게임 오브젝트들을 인스펙터 창에서 등록 후 ID에 맞추어 사용하기 위해 만든 구조체. list로 사용할 것.
/// </summary>
[System.Serializable]
public struct NumObject
{
    public int num;
    public GameObject value;
}
/// <summary>
/// 맨 처음 스테이지에서, 버튼을 클릭하면 화면을 하나씩 넘겨주는 함수
/// </summary>
public class Tutorial : MonoBehaviour
{
    [SerializeField]
    private List <NumObject> _tutorial;
    private int currentNum = 0;
    private GameObject currentValue;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            currentValue = _tutorial.Find(x => x.num == currentNum).value;
            
            foreach (NumObject obj in _tutorial)
            {
                obj.value.SetActive(false);
            }
            currentValue.SetActive(true);
            
            if (currentNum < _tutorial.Count)
            {
                currentNum++;
            }
            else
            {
                currentNum = 0;
            }
        }    
    }

}
