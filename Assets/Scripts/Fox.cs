﻿using UnityEngine;

[RequireComponent(typeof(Attacker))]
public class Fox : MonoBehaviour
{
    private Animator _animator;
    private Attacker _attacker;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _attacker = GetComponent<Attacker>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        var obj = collider.gameObject;

        if (!obj.GetComponent<Defender>())
        {
            return;
        }

        if (obj.GetComponent<Stone>())
        {
            _animator.SetTrigger("jumpTrigger");
        }
        else
        {
            _animator.SetBool("isAttacking", true);
            _attacker.Attack(obj);
        }
    }
}
