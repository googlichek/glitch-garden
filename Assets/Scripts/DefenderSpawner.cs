using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public Camera GameCamera;

    private GameObject _defenderParent;
    private StarDisplay _starDisplay;

    void Start()
    {
        _defenderParent = GameObject.Find("Defenders");
        _starDisplay = FindObjectOfType<StarDisplay>();

        if (!_defenderParent)
        {
            _defenderParent = new GameObject("Defenders");
        }
    }

    void OnMouseDown()
    {
        Vector2 rawPosition = CalculateWorldPointsOfMouseClick();
        Vector2 position = SnapToGrid(rawPosition);

        GameObject defender = Button.SelectedDefender;

        int defenderCost = defender.GetComponent<Defender>().StarCost;
        if (_starDisplay.UseStars(defenderCost) == StarDisplay.Status.Success)
        {
            SpawnDefender(defender, position);
        }
        else
        {
            Debug.Log("Insufficient stars to spawn");
        }
    }

    private void SpawnDefender(GameObject defender, Vector2 position)
    {
        Quaternion zeroRotation = Quaternion.identity;

        GameObject actualDefender = Instantiate(defender, position, zeroRotation) as GameObject;
        actualDefender.transform.parent = _defenderParent.transform;
    }

    private Vector2 CalculateWorldPointsOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);

        Vector2 worldPosition = GameCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPosition;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPosition)
    {
        float newX = Mathf.RoundToInt(rawWorldPosition.x);
        float newY = Mathf.RoundToInt(rawWorldPosition.y);

        return new Vector2(newX, newY);
    }
}
