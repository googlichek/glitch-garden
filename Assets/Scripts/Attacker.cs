using UnityEngine;

public class Attacker : MonoBehaviour
{
    private float _currentSpeed;
    private GameObject _currentTarget;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.left * _currentSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D()
    {
    }

    public void SetSpeed(float speed)
    {
        _currentSpeed = speed;
    }

    public void StrikeCurrentTarget(float damage)
    {
    }

    public void Attack(GameObject obj)
    {
        _currentTarget = obj;
    }
}
