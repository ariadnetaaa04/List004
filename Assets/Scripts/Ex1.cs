using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    private int totalCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Coins();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log($"There is {totalCoins} coins in the box");
        }
    }

    private void Coins()
    {
        totalCoins++;
    }
}
