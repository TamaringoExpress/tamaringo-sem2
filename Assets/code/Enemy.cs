using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private Health health = new Health();
     
    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public void TakeDamage(int damage)
    {
        health.TakeDamage(damage);
    }

}
