using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    [SerializeField] private int _x;
    [SerializeField] private int _y;
    [SerializeField] private GameObject _objectInHex;
    public void Setup(int x,int y) 
    {
        _x = x;
        _y = y;
    }

    public GameObject GetObjectInHex() 
    {
        return _objectInHex;
    }
}
