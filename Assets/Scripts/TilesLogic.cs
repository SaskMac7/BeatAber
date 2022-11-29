using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesLogic : MonoBehaviour
{
    public Saber SaberCheck;
    public GameObject SaberObj;

    public GameObject TileTopR;
    public GameObject TileTopL;
    public GameObject TileBotR;
    public GameObject TileBotL;

    public GameObject Top;
    public GameObject Bottom;
    public GameObject Right;
    public GameObject Left;

    public Rigidbody rbR;
    public Rigidbody rbL;

    public bool access;


    void Start()
    {
        rbR = Right.GetComponent<Rigidbody>();
        rbL = Left.GetComponent<Rigidbody>();

        Invoke("giveSaberDelay", 2f);
        
    }

    void Update()
    {
        if (access == true)
        {
            if (SaberCheck.CheckCut == 1)
                {
                    TopCut();
                }
        }       
    }

    public void giveSaberDelay()
    {
        SaberObj = GameObject.Find("lightsaber");
        SaberCheck = SaberObj.GetComponent<Saber>();
        access = true;
    }

    public void TopCut()
    {
        TileTopR.transform.SetParent(null);
        TileTopL.transform.SetParent(null);
        TileBotR.transform.SetParent(null);
        TileBotL.transform.SetParent(null);

        Top.transform.SetParent(null);
        Bottom.transform.SetParent(null);
        Right.transform.SetParent(null);
        Left.transform.SetParent(null);

        TileTopL.transform.SetParent(Left.transform);
        TileBotL.transform.SetParent(Left.transform);
        TileTopR.transform.SetParent(Right.transform);
        TileBotR.transform.SetParent(Right.transform);

        rbR.useGravity = true;
        rbL.useGravity = true;
    }


}
