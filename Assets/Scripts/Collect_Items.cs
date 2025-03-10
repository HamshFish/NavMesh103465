using UnityEngine;

public class Collect_Items : MonoBehaviour
{

    public Sliding_Door door;
    public int collectedItems = 0;
    public int reqiredItems = 3;
    

    // Update is called once per frame
    void Update()
    {
        if (collectedItems >= reqiredItems)
        {
            door.OpenTheDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable") 
        {
            collectedItems++;
            Debug.Log("test");
            Destroy(other.gameObject);
        }
    }
}
