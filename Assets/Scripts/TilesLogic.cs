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
    public Rigidbody rbT;
    public Rigidbody rbB;

    public bool access;


    void Start()
    {
        rbR = Right.GetComponent<Rigidbody>();
        rbL = Left.GetComponent<Rigidbody>();
        rbT = Top.GetComponent<Rigidbody>();
        rbB = Bottom.GetComponent<Rigidbody>();

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

            if (SaberCheck.CheckCut == 2)
            {
                TopCut();
            }

            if (SaberCheck.CheckCut == 3)
            {
                LeftCut();
            }

            if (SaberCheck.CheckCut == 4)
            {
                LeftCut();
            }

        }       
    }

    public void giveSaberDelay()
    {
        SaberObj = GameObject.Find("lightsaber");
        SaberCheck = SaberObj.GetComponent<Saber>();
        access = true;
    }

    public void NullParent()
    {
        TileTopR.transform.SetParent(null);
        TileTopL.transform.SetParent(null);
        TileBotR.transform.SetParent(null);
        TileBotL.transform.SetParent(null);

        Top.transform.SetParent(null);
        Bottom.transform.SetParent(null);
        Right.transform.SetParent(null);
        Left.transform.SetParent(null);
    }

    public void TopCut()
    {
        NullParent();

        TileTopL.transform.SetParent(Left.transform);
        TileBotL.transform.SetParent(Left.transform);
        TileTopR.transform.SetParent(Right.transform);
        TileBotR.transform.SetParent(Right.transform);

        rbR.useGravity = true;
        rbL.useGravity = true;
    }

    public void LeftCut()
    {
        NullParent();

        TileTopL.transform.SetParent(Top.transform);
        TileTopR.transform.SetParent(Top.transform);
        TileBotL.transform.SetParent(Bottom.transform);
        TileBotR.transform.SetParent(Bottom.transform);

        rbT.useGravity = true;
        rbB.useGravity = true;
    }


}
