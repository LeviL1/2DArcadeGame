using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPickup : MonoBehaviour
{
  private GasTank tank;
  private Rigidbody2D body;
  private void Start()
  {
    body = this.GetComponent<Rigidbody2D>();
    tank = GameObject.FindGameObjectWithTag("Player").GetComponent<GasTank>();
    body.AddForce(new Vector2(-500, 0), ForceMode2D.Force);
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
