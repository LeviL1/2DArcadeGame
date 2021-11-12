using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkcar : MonoBehaviour
{
  public Vector2 startPosition;
  public Collider2D othercollider;
  // Start is called before the first frame update
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.transform.tag == "Enemy")
    {
      Destroy(collision.gameObject, 2f);
    }
    if (collision.transform.tag == "Pickup") 
    {
      Destroy(collision.gameObject, 2f);
    }
    
  }
  

  

}
