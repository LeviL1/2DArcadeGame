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
 
  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Player" && tank.gasAmt < 75)
    {
      tank.gasAmt += 25f;
      Destroy(this.gameObject);
    }
  }
}
