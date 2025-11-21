using UnityEngine;
using UnityEngine.Events;

public class CoinBehavior : MonoBehaviour
{
    private CircleCollider2D circleCollider2D;
    private SpriteRenderer spriteRenderer;
    public UnityEvent onDeath;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            circleCollider2D.enabled = false;
            spriteRenderer.color = new Color(1, 1, 1, 0);
            onDeath.Invoke();
        }
    }
}
