using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject hero;
    [SerializeField] float speed = 0.1f;
    [SerializeField] float distanceForSwap = 8;
    
    [SerializeField] float minX = -24;
    [SerializeField] float maxX = 24;

    [SerializeField] float minY = -13;
    [SerializeField] float maxY = 13f;

    [SerializeField] float minZ = 0;
    [SerializeField] float maxZ = 0;

    [SerializeField] int numEnemy = 8;

    [SerializeField] GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numEnemy; i++) 
        {
        
        GameObject target = Instantiate(Enemy, new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ)), Quaternion.identity);
        
        target.GetComponent<NewChase>()._hero = target.GetComponent<NewRetreat>()._hero = hero;
        target.GetComponent<NewChase>()._speed = target.GetComponent<NewRetreat>()._speed = speed;
        target.GetComponent<NewChase>()._distanceForSwap = target.GetComponent<NewRetreat>()._distanceForSwap = distanceForSwap;
        
        }
    }
}
