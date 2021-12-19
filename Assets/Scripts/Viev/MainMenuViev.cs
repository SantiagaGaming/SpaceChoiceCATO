using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MainMenuViev : MonoBehaviour
{
    public UnityAction StartGameEvent;
    public UnityAction ExitGameEvent;

    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject _loadingPanel;
    [SerializeField] private Text _loadingText;
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _exitGameButton;

    private void Start()
    {
        _startGameButton.onClick.AddListener(() => { StartGameEvent?.Invoke(); });
        _exitGameButton.onClick.AddListener(() => { ExitGameEvent?.Invoke(); });
        _loadingText.text = "Loading";
    }
    public void UpdateLoadingText(string text)
    {
        _loadingText.text += text;
    }
    public void HideMainPanel()
    {
        _mainPanel.SetActive(false);
        _loadingPanel.SetActive(true);
    }


}
