using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PineappleObj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static Vector3 getRandomPosition(float a, float b, float c, float d)
    {
        Vector3 randomPosition = new Vector3(Random.Range(a, b), 0, Random.Range(c, d));
        return randomPosition;
    }

    public void createFruits(int number)
    {
        //Vector3(-9.06000042,0,-8.03999996)
        //Vector3(9.26000023,0,-8.03999996)
        //Vector3(9.26000023,0,7.92999983)
        //Vector3(-9.25,0,-8.1260004)
        for(int i = 0; i<number; i++)
        {
            GameObject fruit = Instantiate(PineappleObj, getRandomPosition(-9f, 9f, 7.5f, -8f), Quaternion.identity);
        }
    }
}
