using UnityEngine;

public class weapon : MonoBehaviour
{
    private int damage = 30;
    private int ammo = 10;


    void Start()
    {

    }
    public void Shoot(Player target)
    {
        if (target == null || ammo == 0)
             return; 
      
        if (ammo >= 1)
        {
            target.TakeDamage(damage);
            ammo--;
            Debug.Log("BAM");
        }
        else
        {
            Debug.LogWarning("no tienes municion");
        }
    }

 

}
