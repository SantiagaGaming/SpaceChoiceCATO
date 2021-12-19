using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource _source;
    [SerializeField] private AudioClip _startgame, _choiceShip, _getNumber, _updateSuond;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }
    public void PlayStartGameSound()
    {
        _source.PlayOneShot(_startgame);
    }
    public void PlayChoiceShipSound()
    {
        _source.PlayOneShot(_choiceShip);
    }
    public void PlayGetNumberSound()
    {
        _source.PlayOneShot(_getNumber);
    }
    public void PlayGetUpdateSound()
    {
        _source.PlayOneShot(_updateSuond);
    }
}
