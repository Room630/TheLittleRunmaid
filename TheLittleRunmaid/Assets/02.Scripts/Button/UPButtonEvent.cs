using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UPButtonEvent : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown (PointerEventData ed) 
    {
        PlayerController.UpMove = true;
    }

    public void OnPointerUp (PointerEventData ed) 
    {
        PlayerController.UpMove = false;
    }
}
