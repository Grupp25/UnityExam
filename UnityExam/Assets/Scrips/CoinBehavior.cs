using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    private CircleCollider2D circleCollider2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        circleCollider2D = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
