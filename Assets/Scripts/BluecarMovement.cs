using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluecarMovement : MonoBehaviour
{
  Rigidbody2D rigidB;
  public Vector2 carPosition;
  public Vector3 targetPosition;
  private Vector2 initialPosition;
  private GasTank tank;
  
  
    // Start is called before the first frame update
    void Start()
    {
    initialPosition.x = this.transform.position.x;
    initialPosition.y = this.transform.position.y;
    rigidB = this.GetComponent<Rigidbody2D>();
    tank = GameObject.FindGameObjectWithTag("Player").GetComponent<GasTank>();
    carPosition.x = Random.Range(-750f, -1000f);
    rigidB.AddForce(carPosition);
    
    }
  private void FixedUpdate()
  {
    if (this.transform.position.x <= targetPosition.x) 
    {
      rigidB.MovePosition(initialPosition);
    }
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("Player")) 
    {
      tank.GetWrecked(25);
    }
  }


}
