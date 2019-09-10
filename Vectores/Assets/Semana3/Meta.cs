using UnityEngine;

public class Meta : MonoBehaviour
{
    public float explosionRadius = 3.0f;
    public Transform agent;
  public GameObject Agent;

    void OnDrawGizmosSelected()
    {
        // Display the explosion radius when selected
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);

    }


    void Start()
    {

    }   

     void Update()
    {
        if (agent)
        {
            Vector3 offset = agent.position - transform.position;
            float sqrLen = offset.sqrMagnitude;

            // square the distance we compare with
            if (sqrLen < 5)
            {
                Destroy(Agent);
                print("Ganaste");
            }
        }
    }
}