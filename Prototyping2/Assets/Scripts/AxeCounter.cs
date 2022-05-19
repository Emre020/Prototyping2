using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxeCounter : MonoBehaviour
{
    public static int AxeAmount;
    private Text AxeCount;
    // Start is called before the first frame update
    void Start()
    {
        AxeCount = GetComponent<Text>();
        AxeAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        AxeCount.text = "Axe: " + AxeAmount;
    }
}
