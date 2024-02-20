using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public int width;
    public int height;
    public GameObject tilePrefab;
    public GameObject[] gems;
    
    // Start is called before the first frame update
    void Start()
    {
        SetUp();
    }

    private void SetUp()
    {
        for(int i =0; i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
                Vector2 tempPosition = new Vector2(i, j);
                GameObject backgroundTile = Instantiate(tilePrefab, tempPosition, Quaternion.identity) as GameObject;
                backgroundTile.transform.parent = this.transform;
                backgroundTile.name = "( " + i + ", " + j + " )";
                int gemToUse = Random.Range(0, gems.Length);
                GameObject gem = Instantiate(gems[gemToUse], transform.position, Quaternion.identity);
                gem.transform.parent = this.transform;
                gem.name = "( " + i + ", " + j + " )";
            }
        }
    }
}