using System;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject Gun;

    private GameObject _projectileParent;
    private Animator _animator;
    private Spawner _matchingLaneSpawner;

    void Start()
    {
        _projectileParent = GameObject.Find("Projectiles");

        if (!_projectileParent)
        {
            _projectileParent = new GameObject("Projectiles");
        }

        _animator = FindObjectOfType<Animator>();
        SetMatchingLaneSpawner();
    }

    void Update()
    {
        if (IsAttackerAheadInLane())
        {
            _animator.SetBool("isAttacking", true);
        }
        else
        {
            _animator.SetBool("isAttacking", false);
        }
    }

    private void SetMatchingLaneSpawner()
    {
        Spawner[] spawnerArray = FindObjectsOfType<Spawner>();

        foreach (var spawner in spawnerArray)
        {
            if (Math.Abs(spawner.transform.position.y - transform.position.y) < 0.5)
            {
                _matchingLaneSpawner = spawner;
                return;
            }
        }

        Debug.LogError(name + "^ can't find spawner in lane.");
    }

    private bool IsAttackerAheadInLane()
    {
        if (_matchingLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }

        foreach (Transform attacker in _matchingLaneSpawner.transform)
        {
            if (attacker.transform.position.x > transform.position.x)
            {
                return true;
            }
        }

        return false;
    }

    private void Fire()
    {
        GameObject projectile = Instantiate(Projectile) as GameObject;
        projectile.transform.parent = _projectileParent.transform;
        projectile.transform.position = Gun.transform.position;
    }
}
