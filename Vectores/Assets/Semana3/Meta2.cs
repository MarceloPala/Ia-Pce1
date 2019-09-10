using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta2 : MonoBehaviour
{
public float explosionRadius = 10.0f;
 public Transform agent;
 public GameObject Agent;

     void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

     void Update()
    {
        if (agent)
        {
            Vector3 offset = agent.position - transform.position;
            float sqrLen = offset.sqrMagnitude;

            if (sqrLen >= 150)
            {
                Destroy(Agent);
                print("Perdiste");
            }
        }

    }
}
