using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{
    public static int KeyAmount;
    private Text KeyCount;
    // Start is called before the first frame update
    void Start()
    {
        KeyCount = GetComponent<Text>();
        KeyAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        KeyCount.text = "Keys: " + KeyAmount;
    }
}
