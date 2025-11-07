using UnityEngine;

public class script1 : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(-50, 0, 0);
    }

    void Update()
    {
        
    }
}
