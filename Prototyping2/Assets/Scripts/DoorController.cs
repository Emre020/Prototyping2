using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    public bool isNotOpen;

    public void OpenDoor(GameObject obj)
    {
        if (!isNotOpen)
        {
            PlayerManager manager = obj.GetComponent<PlayerManager>();
            if (manager)
            {
                if (manager.keyCount > 0)
                {
                    isNotOpen = true;
                    manager.UseKey();
                    Debug.Log("Door is unlocked!");
                }
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
