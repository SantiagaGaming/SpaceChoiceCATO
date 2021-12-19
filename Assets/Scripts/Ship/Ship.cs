using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public int Counter;

    [SerializeField] private GameObject[] _ships;

    private GameObject _currentShip;

    private void Update()
    {
            _currentShip.transform.DOMove(new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), 120);
    }

    private void Start()
    {
      _currentShip = Instantiate(_ships[Random.Range(0,_ships.Length)],transform);
    }

}
