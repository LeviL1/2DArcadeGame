using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
  public float driftFactor = 0f;
  public float accelerationFactor = 30.0f;
  public float turnFactor = 3.5f;
  public float maxSpeed = 20f;
  float accelerationInput = 0f;
  float steeringInput = 0f;
  float rotationAngle = 0f;

  float velvsUp = 0f;
  Rigidbody2D carRigidbdy;

    // Start is called before the first frame update
    void Awake()
    {
    carRigidbdy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    ApplyEngineForce();

    ApplySteering();
    }
  void ApplyEngineForce()
  {
    velvsUp = Vector2.Dot(transform.up, carRigidbdy.velocity);
    if (velvsUp > maxSpeed && accelerationInput > 0)
    {
      return;
    }
    if (velvsUp < -maxSpeed * 0.5f && accelerationInput > 0)
    {
      return;
    }
    if (carRigidbdy.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
    {
      return;
    }
    if (accelerationInput == 0)
    {
      carRigidbdy.drag = Mathf.Lerp(carRigidbdy.drag, 3.0f, Time.fixedDeltaTime * 3);
    }
    else carRigidbdy.drag = 0f;
    Vector2 engineForce = transform.up * accelerationInput * accelerationFactor;
    carRigidbdy.AddForce(engineForce, ForceMode2D.Force);
  }
  void ApplySteering()
  {
    float minSpeedBeforeTurn = (carRigidbdy.velocity.magnitude / 8);
    minSpeedBeforeTurn = Mathf.Clamp01(minSpeedBeforeTurn);

    rotationAngle -= steeringInput * turnFactor * minSpeedBeforeTurn;
    carRigidbdy.MoveRotation(rotationAngle);
  }

  public void SetInputVector(Vector2 vector) 
  {
    steeringInput = vector.x;
    accelerationInput = vector.y;
  }
  void KillVelocity()
  {
    Vector2 fowardVelocity = transform.up * Vector2.Dot(carRigidbdy.velocity, transform.up);
    Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbdy.velocity, transform.right);

    carRigidbdy.velocity = fowardVelocity + rightVelocity * driftFactor;
  }
}
