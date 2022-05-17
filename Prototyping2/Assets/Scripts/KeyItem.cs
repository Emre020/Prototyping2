using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    void OnTriggerEnter(PlayerManager other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
        }
    }
}