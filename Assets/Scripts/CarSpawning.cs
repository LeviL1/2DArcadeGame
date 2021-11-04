using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawning : MonoBehaviour
{
   public GameObject[] spawnPoints;
  public GameObject[] cars;
  private float nextSpawn = 0f;
  public float spawnRate;
  
  private void FixedUpdate()
  {
    if (Time.time >= nextSpawn)
    {
      Instantiate(cars[Random.Range(0, 3)], spawnPoints[Random.Range(0, 3)].transform);
      nextSpawn = Time.time + 1f / spawnRate;
    }
  }


}
