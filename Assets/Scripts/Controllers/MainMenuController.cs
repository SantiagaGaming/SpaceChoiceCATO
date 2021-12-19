using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private MainMenuViev _viev;
    [SerializeField] private SceneLoader _loader;
    [SerializeField] private SoundController _sound;

    private void OnEnable()
    {
        _viev.StartGameEvent += OnStartGame;
        _viev.ExitGameEvent += OnExitGame;
    }
    private void OnDisable()
    {
        _viev.StartGameEvent -= OnStartGame;
        _viev.ExitGameEvent -= OnExitGame;
    }
    private void OnStartGame()
    {
        _viev.HideMainPanel();
        _sound.PlayStartGameSound();
        StartCoroutine(LoadingTextUpdater());
  
    }
    private void OnExitGame()
    {
        Application.Quit();
    }
    private IEnumerator LoadingTextUpdater()
    {
        int counter = 0;
        while (counter < 3)
        {
            _viev.UpdateLoadingText(".");
            yield return new WaitForSeconds(0.3f);
            counter++;
        }
        yield return new WaitForSeconds(0.5f);
        _loader.LoadScene(Helper.GAME_SCENE);

    }

}
