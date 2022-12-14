using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{ 
    public GameObject[] figurePrefabs; //Array de las figuras
    private int figureIndex; //indice del array de las figuras
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
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomFigure();
        }
    }
        
      private void SpawnRandomFigure()
    {
        
        figureIndex = Random.Range(0, figurePrefabs.Length); //genera un indice aleatorio
        //Instantiate hacer aparecer algo en la pantalla 
        Instantiate(figurePrefabs[figureIndex],
        RandomSpawnPos(), figurePrefabs[figureIndex].transform.rotation);
    }
    
    private Vector3 RandomSpawnPos(float rangeX, float rangeY)
    {
        float randomX = Random.Range(-rangeX, rangeX); //Genera numero aleatorio para la posicion en x
        float randomY = Random.Range(-rangeY, rangeY);
        Debug.Log($"The random vector is {randomX}, {randomY}, 0");
        return new Vector3(randomX, randomY, 0);
        
    }
    
}
