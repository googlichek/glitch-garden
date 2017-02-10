using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public static GameObject SelectedDefender;
    public GameObject DefenderPrefab;

    private Button[] _buttonArray;
    private Text _costText;

    private void Start()
    {
        _buttonArray = FindObjectsOfType<Button>();

        _costText = GetComponentInChildren<Text>();
        _costText.text = DefenderPrefab.GetComponent<Defender>().StarCost.ToString();
    }

    void OnMouseDown()
    {
        foreach (Button button in _buttonArray)
        {
            button.GetComponent<SpriteRenderer>().color = Color.black;

        }

        GetComponent<SpriteRenderer>().color = Color.white;
        SelectedDefender = DefenderPrefab;
    }
}
