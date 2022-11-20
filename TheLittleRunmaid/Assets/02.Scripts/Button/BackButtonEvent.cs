using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BackButtonEvent : MonoBehaviour, IPointerClickHandler
{
    public GameObject settingPanel;

    public void OnPointerClick (PointerEventData ed) 
    {
        settingPanel.SetActive(!settingPanel.activeSelf);
    }

}
