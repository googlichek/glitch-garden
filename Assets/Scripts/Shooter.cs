using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject Gun;

    private GameObject _projectileParent;

    void Start()
    {
        _projectileParent = GameObject.Find("Projectiles");

        if (!_projectileParent)
        {
            _projectileParent = new GameObject("Projectiles");
        }
    }

    private void Fire()
    {
        GameObject projectile = Instantiate(Projectile) as GameObject;
        projectile.transform.parent = _projectileParent.transform;
        projectile.transform.position = Gun.transform.position;
    }
}
