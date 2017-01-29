using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(-1.5f, 1.5f)]
    public float WalkSpeed;

    void Update()
    {
        transform.Translate(Vector3.left * WalkSpeed * Time.deltaTime);
    }
}
