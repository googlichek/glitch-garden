using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(-1.5f, 1.5f)]
    public float CurrentSpeed;

    void Start()
    {
        Rigidbody2D rigidbody = gameObject.AddComponent<Rigidbody2D>();
        rigidbody.isKinematic = true;
    }

    void Update()
    {
        transform.Translate(Vector3.left * CurrentSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D()
    {
    }

    public void SetSpeed(float speed)
    {
        CurrentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damage)
    {
    }
}
