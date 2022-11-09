using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DashButtonEvent : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public void OnPointerDown (PointerEventData ed) 
    {
        PlayerController.Dash = true;
    }

    public void OnPointerUp (PointerEventData ed) 
    {
        PlayerController.Dash = false;
    }
}
