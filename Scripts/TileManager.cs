using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public float zSpawn;
    public float tileLenght;
    public int numberofTiles = 5;

    public Transform playerTransform;

    public GameObject sta;

    private List<GameObject> activeTiles=new List<GameObject>();
    void Start()
    {
        sta.SetActive(false);
        for(int i=0; i < numberofTiles; i++)
        {
            if (i == 0)
            {
                SpawnTile(0);
            }
            else
            {
                SpawnTile(Random.Range(0, tilePrefabs.Length));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > zSpawn -(numberofTiles*tileLenght))
        {
            SpawnTile(Random.Range(0, tilePrefabs.Length));
            DeleteTile();
        }
    }

    public void SpawnTile(int tileIndex)
    {
       GameObject go= Instantiate(tilePrefabs[tileIndex],transform.forward*zSpawn,transform.rotation);
        activeTiles.Add(go);
        zSpawn += tileLenght;
    }
    void DeleteTile()
    {
        Destroy(activeTiles[0],7);
        activeTiles.RemoveAt(0);    
    }
}
