using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTiles : MonoBehaviour
{
    public GameObject Tile;
    public GameObject tempTile;

    public Rigidbody rb;

    private int xPos;
    void Start()
    {
        Invoke("SpawnTile", 0.7f);
        
    }

    void Update()
    {

    }

    public void SpawnTile()
    {
        if (Random.Range(0, 2) == 1)
        {
            xPos = -1;
        }
        else
        {
            xPos = 1;
        }
        tempTile = Instantiate(Tile, new Vector3(transform.position.x + xPos, 2, 10), Quaternion.identity);

        rb = tempTile.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -3);


        Invoke("SpawnTile", 2f);
    }
}
