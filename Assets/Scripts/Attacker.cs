using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Tooltip("Average number of seconds between appearances")]
    public float SeenEverySeconds;

    private float _currentSpeed;
    private GameObject _currentTarget;
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * _currentSpeed * Time.deltaTime);
        if (!_currentTarget)
        {
            _animator.SetBool("isAttacking", false);
        }
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
        if (_currentTarget)
        {
            var health = _currentTarget.GetComponent<Health>();

            if (health)
            {
                health.DealDamage(damage);
            }
        }
    }

    public void Attack(GameObject obj)
    {
        _currentTarget = obj;
    }
}
