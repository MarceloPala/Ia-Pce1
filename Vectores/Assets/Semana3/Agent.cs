using UnityEngine;

public class Agent : MonoBehaviour
{
    Vector3 Velocity = Vector3.zero;
    Vector3 Desired = Vector3.zero;
    Vector3 Steer = Vector3.zero;

    float maxSpeed = 5;
    float maxSteer = 2;


Transform target;

    void Update()
    {
        target = GameObject.Find("Target").transform;

     //desired
     Desired = (target.position - transform.position).normalized * maxSpeed;

     //Steer
     Steer = Vector3.ClampMagnitude(Desired - Velocity, maxSteer);
     
     //Velocity
     Velocity += Steer * Time.deltaTime;
     transform.position -= Velocity * Time.deltaTime;

    }



}
