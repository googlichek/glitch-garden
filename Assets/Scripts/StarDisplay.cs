using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour
{
    public Text StarsCountText;

    private int _starsCount;

    public void AddStars(int amount)
    {
        _starsCount += amount;
        StarsCountText.text = _starsCount.ToString();
    }

    public void UseStars(int amount)
    {
        _starsCount -= amount;
        StarsCountText.text = _starsCount.ToString();
    }
}
