using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public GameObject interactNotification;

    public void PickupKey()
    {
        KeyCounter.KeyAmount++;
        Debug.Log("Picked up key");
    }

    public void UseKey()
    {
        KeyCounter.KeyAmount--;
        Debug.Log("Used a key");
    }

    public void PickupAxe()
    {
        AxeCounter.AxeAmount++;
        Debug.Log("Picked up key");
    }

    public void UseAxe()
    {
        AxeCounter.AxeAmount--;
        Debug.Log("Used a key");
    }

    public void NotifyPlayer()
    {
        interactNotification.SetActive(true);
    }

    public void DeNotifyPlayer()
    {
        interactNotification.SetActive(false);
    }

}
