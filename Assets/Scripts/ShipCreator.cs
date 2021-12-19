using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCreator : MonoBehaviour
{
    [SerializeField] private Ship _ship;
   private int _count =7;

    private float _xPoz = 10;

    private void Start()
    {
        CreateShips();
    }
    private void CreateShips()
    {
        int creator = 1;
        while(creator<_count)
        {
           Ship temp =  Instantiate(_ship, new Vector3(_xPoz, 0, -1.9f), Quaternion.identity);
            temp.Counter = creator;
            _xPoz -= 4;
                creator++;
        }
    }
}
