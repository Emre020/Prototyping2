using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    [SerializeField]
    private Text PickUpText;

    private bool PickUpAllowed;

    public static int AxeAmount;
    private Text AxeCount;

    // Start is called before the first frame update
    void Start()
    {
        PickUpText.gameObject.SetActive(false);

        AxeCount = GetComponent<Text>();
        AxeAmount = 0;
    }

    int key;

    // Update is called once per frame
    void Update()
    {
        if (PickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickupKey();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("FirstPersonPlayer"))
        {
            PickUpText.gameObject.SetActive(true);
            PickUpAllowed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Equals("FirstPersonPlayer"))
        {
            PickUpText.gameObject.SetActive(false);
            PickUpAllowed = false;
        }
    }

    private void PickupKey()
    {
        Destroy(gameObject);
    }

    void Update1()
    {
        AxeCount.text = "Axe: " + AxeAmount;
    }
}
