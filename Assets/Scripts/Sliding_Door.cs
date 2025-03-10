using UnityEngine;

public class Sliding_Door : MonoBehaviour
{
    public Vector3 positionOffset = new Vector3(0f, -2f, 0f);
    public float speed = 5f;
    private Vector3 openPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        openPosition = transform.position + positionOffset;
    }

    public void OpenTheDoor()
    {
        transform.position = Vector3.MoveTowards(transform.position, openPosition, speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        //OpenTheDoor();
    }


}
