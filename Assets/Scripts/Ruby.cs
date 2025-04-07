using UnityEngine;
using UnityEngine.AI;

public class Ruby : MonoBehaviour
{
    public Transform teleportTo;
    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        NavMeshAgent agent = other.GetComponent<NavMeshAgent>();
        agent.enabled = false;
        // if (other.CompareTag("Player")) { 
        TeleportPlayer();
        agent.enabled = true;

    }
    void TeleportPlayer()
    {
        player.transform.position = teleportTo.position;
        player.transform.rotation = teleportTo.rotation;
    }
}
