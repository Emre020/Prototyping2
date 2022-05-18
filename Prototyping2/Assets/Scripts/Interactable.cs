using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange) // Wenn in Reichweite, dann interagiere
        {
            if (Input.GetKeyDown(interactKey)) //Player presses Key
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            other.gameObject.GetComponent<PlayerManager>().NotifyPlayer();
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            other.gameObject.GetComponent<PlayerManager>().DeNotifyPlayer();
            Debug.Log("Player now not in range");
        }
    }
}
