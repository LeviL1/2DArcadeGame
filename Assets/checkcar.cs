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
      othercollider.isTrigger = true;
    }
    else { return; }
  }
  private void OnTriggerStay(Collider other)
  {
    if (other.tag == "Enemy")
    {
      othercollider.isTrigger = true;
    }
  }
  private void OnTriggerExit2D(Collider2D other)
  {
    if (other.tag == "Enemy") 
    {
      othercollider.isTrigger = false;
    }
  }

}
