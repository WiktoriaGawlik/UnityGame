using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToShip : MonoBehaviour
{
    public GameObject UIPanel;
    public GameObject UIPanelNotFinished;
    public GameObject UIPanelFinished;
    public PickupController pickupController;
    private bool isQuestFinished = false;
  

    private void Start()
    {
        HideUI();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) == true)
        {
            if (pickupController.GotAllPickups() == false)
            {
                UIPanelNotFinished.SetActive(true);
                UIPanelFinished.SetActive(false);
            }

            else
            {
                UIPanelFinished.SetActive(true);
                UIPanelNotFinished.SetActive(false);
              
            }
        }
    }

    private void TeleportEnd()
    {
        if (Input.GetKeyDown(KeyCode.E) == true)
        {
            SceneManager.LoadScene("End");
        }
    }

    public void ShowUI()
    {
        UIPanel.SetActive(true);
    }
    public void HideUI()
    {
        UIPanel.SetActive(false);
        UIPanelNotFinished.SetActive(false);
        UIPanelFinished.SetActive(false);
    }
}
