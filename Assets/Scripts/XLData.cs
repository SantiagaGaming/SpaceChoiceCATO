using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class XLData : MonoBehaviour
{
    [SerializeField] private TextAsset _data;
    private string[,] _finalData;


    private void Start()
    {
        _finalData = new string[7,7];
        LoadData();
       
    }
    public void LoadData()
    {
        string[] data = _data.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
        int counter =0;
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                    _finalData[i, j] = data[counter];
                counter++;
            }
        }
       

    }
    public string GetData(int x,int y)
    {
        return _finalData[x, y];
    }

}
