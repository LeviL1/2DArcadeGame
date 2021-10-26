using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPickup : MonoBehaviour
{
  private GasTank tank;
  private void Start()
  {
    tank = GameObject.FindGameObjectWithTag("Player").GetComponent<GasTank>();
  }
 
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player") { Debug.Log("In trigger"); }
  }
}
