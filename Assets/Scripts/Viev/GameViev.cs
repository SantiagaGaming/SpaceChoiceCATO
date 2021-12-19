using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameViev : MonoBehaviour
{
    public UnityAction TapOnExitButtonEvent;
    public UnityAction TapOnUpdateButtonEvent;

    [SerializeField] private Button _exitButton;
    [SerializeField] private Button _updateButton;
    [SerializeField] private Text _mainText;
    [SerializeField] private GameObject _selectText;

    private void Start()
    {
        _exitButton.onClick.AddListener(() => { TapOnExitButtonEvent?.Invoke(); });
        _updateButton.onClick.AddListener(() => { TapOnUpdateButtonEvent?.Invoke(); });
    }
    public void UpdateMainText(string value)
    {
        _mainText.text = value;
    }
    public void ShowSelectText(bool value)
    {
        _selectText.SetActive(value);
    }
}
