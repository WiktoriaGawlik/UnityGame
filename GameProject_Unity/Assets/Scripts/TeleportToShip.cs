using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportToShip : MonoBehaviour
{
    public GameObject UIPanel;

    public void ShowUI()
    {
        UIPanel.SetActive(true);
    }
    public void HideUI()
    {
        UIPanel.SetActive(false);
    }
}
