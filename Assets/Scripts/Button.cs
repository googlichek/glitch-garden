﻿using UnityEngine;

public class Button : MonoBehaviour
{
    public static GameObject SelectedDefender;
    public GameObject DefenderPrefab;

    private Button[] _buttonArray;

    void Start()
    {
        _buttonArray = FindObjectsOfType<Button>();
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
