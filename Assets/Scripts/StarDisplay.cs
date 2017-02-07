using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StarDisplay : MonoBehaviour
{
    public enum Status
    {
        Success,
        Failure
    }

    private Text _starsCountText;
    private int _starsCount = 100;

    void Start()
    {
        _starsCountText = GetComponent<Text>();
        UpdateDisplay();
    }

    public void AddStars(int amount)
    {
        _starsCount += amount;
        UpdateDisplay();
    }

    public Status UseStars(int amount)
    {
        if (_starsCount >= amount)
        {
            _starsCount -= amount;
            UpdateDisplay();

            return Status.Success;
        }

        return Status.Failure;
    }

    private void UpdateDisplay()
    {
        _starsCountText.text = _starsCount.ToString();
    }
}
