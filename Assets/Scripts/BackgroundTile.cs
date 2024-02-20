using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTile : MonoBehaviour
{

    public GameObject[] gems;
    
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Initialize()
    {
        int gemToUse = Random.Range(0, gems.Length);
        GameObject gem = Instantiate(gems[gemToUse], transform.position, Quaternion.identity);
        gem.transform.parent = this.transform;
        gem.name = this.gameObject.name;
    }
}
