using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public GameObject HexTilePrefab;
    [SerializeField] private int _mapWidth = 25;
    [SerializeField] private int _mapHeight = 12;

    [SerializeField]private float tileXoffset = 0;
    [SerializeField]private float tileZOffset = 0f;

    private void Start()
    {
        CreateHexTileMap();
    }

    private void CreateHexTileMap() 
    {
        for (int x = 0; x <= _mapWidth; x++)
        {
            for (int z = 0; z <= _mapHeight; z++) 
            {
                GameObject TempGo = Instantiate(HexTilePrefab);
                if (z % 2 == 0)
                {
                   TempGo.transform.position=new Vector3(x * tileXoffset, z * tileZOffset,0);
                }
                else 
                {
                    TempGo.transform.position = new Vector3(x * tileXoffset + tileXoffset / 2f, tileZOffset,0);   
                }
                SetTileInfo(TempGo, x, z);
            }
    }


}

    private void SetTileInfo(GameObject tempGo, int x, int z)
    {
        tempGo.transform.parent = transform;
        tempGo.name = x.ToString() + ", " + z.ToString();
    }
}
