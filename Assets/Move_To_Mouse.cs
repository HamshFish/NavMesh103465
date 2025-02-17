using UnityEngine;
using UnityEngine.AI;


public class Move_To_Mouse : MonoBehaviour
{
    private NavMeshAgent agent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitinfo;

        if(Physics.Raycast(ray.origin, ray.direction, out hitinfo))
        {
            agent.destination = hitinfo.point;
        }
    }
}
