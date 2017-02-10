using UnityEngine;

public class StopButton : MonoBehaviour
{
    private LevelManager _levelManager;

    void Start()
    {
        _levelManager = FindObjectOfType<LevelManager>();
    }

    void OnMouseDown()
    {
        _levelManager.LoadLevel("01a Start");
    }
}
