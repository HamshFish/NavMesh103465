using UnityEngine;
using UnityEngine.AI;
public class Guide : MonoBehaviour
{
    private NavMeshAgent agent;

    public Move_To_Object moveToObject;
    public Collect_Items[] collectItems;
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] coins;
        coins = GameObject.FindGameObjectsWithTag("Collectable");

        if(coins.Length == 0 )
        {
            moveToObject.enabled = true;
            enabled = false;
            return;
        }

        float shortestDistance = Mathf.Infinity;
        GameObject closestCoin = null;
        foreach(GameObject coin in coins)
        {
            float distance = Vector3.Distance(transform.position, coin.transform.position);
            //float distance = (transform.position - coin.transform.position).magnitude;

            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                closestCoin = coin;
            }
        }

        if(closestCoin != null)
        {
            agent.destination = closestCoin.transform.position; 
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        foreach(Collect_Items items in collectItems)
        {
            items.OnTriggerEnter(other);
        }
    }
}
