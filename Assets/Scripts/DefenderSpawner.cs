using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    public Camera GameCamera;

    private GameObject _defenderParent;

    void Start()
    {
        _defenderParent = GameObject.Find("Defenders");

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
