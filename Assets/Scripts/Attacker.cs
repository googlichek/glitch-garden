using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(-1.5f, 1.5f)]
    public float WalkSpeed;

    void Start()
    {
        Rigidbody2D rigidbody = gameObject.AddComponent<Rigidbody2D>();
        rigidbody.isKinematic = true;
    }

    void Update()
    {
        transform.Translate(Vector3.left * WalkSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D()
    {
        
    }
}
