using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameViev _viev;
    [SerializeField] private SceneLoader _loader;
    [SerializeField] private ShipClick _click;
    [SerializeField] private SoundController _sound;
    [SerializeField] private XLData _data;

    private int _tempInt;
    private void Start()
    {

        _data.LoadData();
    }

    private void OnEnable()
    {
        _viev.TapOnExitButtonEvent += OnExitToMenu;
        _click.ClickOnFirstShipEvent += OnSaveFirstNumber;
        _click.ClickOnSecondShipEvent += OnSetMainText;
        _click.FirstClickEvent += OnFirstClickViev;
        _viev.TapOnUpdateButtonEvent += OnUpdateValues;
    }
    private void OnDisable()
    {
        _viev.TapOnExitButtonEvent -= OnExitToMenu;
        _click.ClickOnFirstShipEvent -= OnSaveFirstNumber;
        _click.ClickOnSecondShipEvent -= OnSetMainText;
        _click.FirstClickEvent -= OnFirstClickViev;
        _viev.TapOnUpdateButtonEvent -= OnUpdateValues;
    }
    private void OnExitToMenu()
    {
        _loader.LoadScene(Helper.MENU_SCENE);
    }
    private void OnSetMainText(int value)
    {
        _sound.PlayGetNumberSound();
        _viev.UpdateMainText(_data.GetData(_tempInt,value)) ;
    }
    private void OnFirstClickViev(bool value)
    {
        _viev.ShowSelectText(value);
        _sound.PlayChoiceShipSound();
    }
    private void OnSaveFirstNumber(int value)
    {
        _tempInt = value;
    }
    private void OnUpdateValues()
    {
        _sound.PlayGetUpdateSound();
        _data.LoadData();
       
    }
}
