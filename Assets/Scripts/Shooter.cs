using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject ProjectileParent;
    public GameObject Gun;

    private void Fire()
    {
        GameObject projectile = Instantiate(Projectile) as GameObject;
        projectile.transform.parent = ProjectileParent.transform;
        projectile.transform.position = Gun.transform.position;
    }
}
