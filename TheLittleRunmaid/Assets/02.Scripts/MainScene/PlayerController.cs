using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 이동 상태 
    public static bool UpMove { get; set; }
    public static bool DownMove { get; set; }
    public static bool Dash { get; set; }

    // 한번에 이동할 Y값
    private Vector3 speed = new Vector3(0, 3, 0);

    private void Start() 
    {

    }

    private void Update() 
    {
        // Up 버튼을 누른 상태
        if (UpMove) // 한계점 필요
        {
            transform.Translate(speed * Time.deltaTime); 
            if (Dash) {
                transform.Translate(speed * 2* Time.deltaTime);
            }
        }
        // Down 버튼을 누른 상태
        if (DownMove) { // 한계점 필요
            transform.Translate(-speed * Time.deltaTime); 
            if (Dash) {
                transform.Translate(-speed * 2* Time.deltaTime);
            }
        }
    }
}
