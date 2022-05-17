using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonPlayer" && GameVariables.keyCount > 0)
        {
            GameVariables.keyCount--;
            Destroy(gameObject);
        }
    }
}
