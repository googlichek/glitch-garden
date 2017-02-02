using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed;
    public float Damage;

    void Update()
    {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
    }
}
