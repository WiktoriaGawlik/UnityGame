using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger enter " + other.gameObject.name);

        TeleportToShip npc = other.gameObject.GetComponent<TeleportToShip>();
        if (npc != null)
        {
            npc.ShowUI();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        TeleportToShip npc = other.gameObject.GetComponent<TeleportToShip>();
        if (npc != null)
        {
            npc.HideUI();
        }
    }

}