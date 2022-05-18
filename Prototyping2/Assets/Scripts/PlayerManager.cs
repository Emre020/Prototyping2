using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public int keyCount;
    public GameObject interactNotification;

    public void PickupKey()
    {
        keyCount++;
        Debug.Log("Picked up key");
    }

    public void UseKey()
    {
        keyCount--;
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
