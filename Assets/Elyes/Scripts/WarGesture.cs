using UnityEngine;

public class WarGesture : MonoBehaviour
{
    public GameObject Arrow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Thraw()
    {
        // add force and throw the arrow on the Y direction
        Rigidbody rb = Arrow.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 0, 1) * 1000);

    }
}
