using UnityEngine;
using UnityEngine.Rendering;

public class Health : MonoBehaviour
{
    private int value;
    

    public void TakeDamage(int damage)
    {
        value -= damage;
        if (value < 0)
            value = 0;
    }
    public int  GetLife()
    {
        return value; 
    }
}
