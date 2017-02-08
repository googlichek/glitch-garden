using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    private LevelManager _levelManager;

    void Start()
    {
        _levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D()
    {
        _levelManager.LoadLevel("03b Lose");
    }
}
