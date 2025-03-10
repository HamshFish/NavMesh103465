using UnityEngine;
using UnityEngine.AI;

public class Speed_modifier : MonoBehaviour
{
    public NavMeshAgent agent;
    public float speedIncrease = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            agent.speed += speedIncrease;
        }
    }
}
