using UnityEngine;

public class Stone : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        Attacker attacker = collider.gameObject.GetComponent<Attacker>();

        if (attacker)
        {
            _animator.SetTrigger("underAttackTrigger");
        }
    }
}
