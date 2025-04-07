using UnityEngine;
using UnityEngine.AI;

public class SlowDownArea : MonoBehaviour
{
    private NavMeshAgent agent;

    float slowSpeed;
    float normalSpeed;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        normalSpeed = agent.speed;
        slowSpeed = agent.speed * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(NavMesh.SamplePosition(agent.transform.position, out NavMeshHit hit, 1f, NavMesh.AllAreas))
        {
            int areaID = hit.mask;
            int grassID = 1 << NavMesh.GetAreaFromName("Grass");
 
            if(areaID == grassID)
            {
                agent.speed = slowSpeed;
            }
            else
            {
                agent.speed = normalSpeed;
            }
        }
    }
}