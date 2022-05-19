using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KetteZerstören : MonoBehaviour
{
    public bool isNotOpen;

    public void OpenDoor(GameObject obj)
    {
        if (!isNotOpen)
        {
            PlayerManager manager = obj.GetComponent<PlayerManager>();
            if (manager)
            {
                if (AxeCounter.AxeAmount > 0)
                {
                    isNotOpen = true;
                    manager.UseKey();
                    Debug.Log("Door is unlocked!");
                }
            }
        }
        else
        {
            OpenDoor();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OpenDoor()
    {
        Destroy(gameObject);
    }
}
