using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    private float rangeX = 5f;
    private float rangeY = 3f;
    // Start is called before the first frame update
    void Start()
    {
        RandomSpawnPos(rangeX,rangeY);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 RandomSpawnPos(float rangeX, float rangeY)
    {
        float randomX = Random.Range(-rangeX, rangeX); //Genera numero aleatorio para la posicion en x
        float randomY = Random.Range(-rangeY, rangeY);
        Debug.Log($"The random vector is {randomX}, {randomY}, 0");
        return new Vector3(randomX, randomY, 0);
        
    }
}
