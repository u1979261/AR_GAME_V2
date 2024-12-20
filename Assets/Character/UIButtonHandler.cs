using System;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{
    [SerializeField] private Button UIShootButton;

    public static event Action OnUIShootButtonClicked;

    void Start()
    {
        UIShootButton.onClick.AddListener(OnShootbuttonClicked);
    }

    void OnShootbuttonClicked()
    {
        OnUIShootButtonClicked?.Invoke();
    }
}
