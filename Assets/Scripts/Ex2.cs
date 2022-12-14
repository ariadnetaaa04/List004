using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    public float cm;
    // Start is called before the first frame update
    void Start()
    {
        Convertor(cm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private float Convertor(float centimetro)
    { 
        float inches=centimetro * 0.39370f;
        Debug.Log($"{centimetro} cm son {inches} pulgadas");
        return inches;
    }

}
