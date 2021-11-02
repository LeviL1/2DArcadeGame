using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  public Transform player; //player transform
  public float dampTime = 0.4f; //how closely the camera follows the player

  private Vector3 _cameraPos; //camera pos as a vector3
  private Vector3 _velocity = Vector3.zero; //velocity = vector.zero
    
    // Update is called once per frame
    void Update()
    {
    _cameraPos = new Vector3(player.position.x, player.position.y, -10f); //find where camera needs to be
    transform.position = Vector3.SmoothDamp(gameObject.transform.position, _cameraPos, ref _velocity, dampTime); //move camera to _cameraPos
    }
}
