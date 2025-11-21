using UnityEngine;

public class BeeBehavior : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private float moveSpeed = 2f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        if (gameObject.transform.position.x == -12.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
