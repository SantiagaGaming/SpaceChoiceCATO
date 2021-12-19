using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShipClick : MonoBehaviour
{

    public UnityAction<int> ClickOnFirstShipEvent;
    public UnityAction<int> ClickOnSecondShipEvent;
    public UnityAction<bool> FirstClickEvent;

    private bool _firstclick = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc.gameObject.TryGetComponent(out Ship ship))
                {
                    if(!_firstclick)
                    {
                        FirstClickEvent?.Invoke(true);
                        _firstclick = true;
                        ClickOnFirstShipEvent?.Invoke(ship.Counter);
                    }
                    else if(_firstclick)
                    {
                        FirstClickEvent?.Invoke(false);
                        _firstclick = false;
                        ClickOnSecondShipEvent?.Invoke(ship.Counter);
                      
                    }
            
                }
                else return;
            }
        }
    }
}