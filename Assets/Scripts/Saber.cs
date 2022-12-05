using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public int CheckCut;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void NullCheckCut()
    {
        CheckCut = 0;
    }

/*    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Top")
        {
            CheckCut = 1;
        }
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Top")
        {
            CheckCut = 1;
            Invoke("NullCheckCut", 0.2f);
        }

        if (other.gameObject.tag == "Bottom")
        {
            CheckCut = 2;
            Invoke("NullCheckCut", 0.2f);
        }

        if (other.gameObject.tag == "Right")
        {
            CheckCut = 3;
            Invoke("NullCheckCut", 0.2f);
        }

        if (other.gameObject.tag == "Left")
        {
            CheckCut = 4;
            Invoke("NullCheckCut", 0.2f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Top")
        {
            CheckCut = 0;
        }

        if (other.gameObject.tag == "Bottom")
        {
            CheckCut = 0;
        }


        if (other.gameObject.tag == "Right")
        {
            CheckCut = 0;
        }


        if (other.gameObject.tag == "Left")
        {
            CheckCut = 0;
        }
    }
}
