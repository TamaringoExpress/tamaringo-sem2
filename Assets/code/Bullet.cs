using UnityEngine;

public class BULLET : MonoBehaviour
{
    [SerializeField] private int damage = 10;
    [SerializeField] private float velocity = 20f;
    private Rigidbody rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * velocity;
        }
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
