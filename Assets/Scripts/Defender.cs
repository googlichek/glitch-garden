using UnityEngine;

public class Defender : MonoBehaviour
{
    public int StarCost = 10;

    private StarDisplay _starDisplay;

    void Start()
    {
        _starDisplay = FindObjectOfType<StarDisplay>();
    }

    public void AddStars(int amount)
    {
        _starDisplay.AddStars(amount);
    }

}
