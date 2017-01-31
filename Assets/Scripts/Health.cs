using UnityEngine;

public class Health : MonoBehaviour
{
    public float UnitHealth = 0f;

    public void DealDamage(float damage)
    {
        UnitHealth -= damage;
        if (UnitHealth < 0)
        {
            DestroyObject();
        }
    }

    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
