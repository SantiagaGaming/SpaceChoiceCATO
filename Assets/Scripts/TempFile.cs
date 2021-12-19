using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempFile 
{
    public int X;
    public int Y;
    private int[,] _tempInt;

    public TempFile(int x, int y)
    {
        X = x;
        Y = y;
        _tempInt = new int[x, y];
    }
    public void FillRandomNumbers()
    {
        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {
                _tempInt[i, j] = Random.Range(100, 1000);
            }
        }
    }
    public int GetRandomNumber(int first,int second)
    {
        return _tempInt[first, second];
    }


}
