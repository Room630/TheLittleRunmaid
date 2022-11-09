using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DownButtonEvent : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown (PointerEventData ed) 
    {
        PlayerController.DownMove = true;
    }

    public void OnPointerUp (PointerEventData ed) 
    {
        PlayerController.DownMove = false;
    }
}
