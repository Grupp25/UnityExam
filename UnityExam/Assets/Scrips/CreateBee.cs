using UnityEngine;

public class CreateBee : MonoBehaviour
{
    public GameObject bee;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(bee,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }
}
