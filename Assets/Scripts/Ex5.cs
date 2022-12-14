using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    private float topBound = 5f;
    private float lowerBound = 3f; 
    private float rangeX = 10f;
     private float rangeY = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InBound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void InBound()
    {
         if (transform.position.z < lowerBound)
        {
            Debug.Log("You are out of bound");
            Destroy(gameObject);
        }
        
        else if (transform.position.z > topBound)
        {
            Debug.Log("You are out of bound");
            Destroy(gameObject);
        }
    }

//para tener pose aleatoria
     private Vector3 RandomSpawnPos(float rangeX, float rangeY)
    {
        float randomX = Random.Range(-rangeX, rangeX); //Genera numero aleatorio para la posicion en x
        float randomY = Random.Range(-rangeY, rangeY);
        Debug.Log($"The random vector is {randomX}, {randomY}, 0");
        return new Vector3(randomX, randomY, 0);
        
    }
}
