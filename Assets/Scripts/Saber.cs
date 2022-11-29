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
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Top")
        {
            CheckCut = 0;
        }
    }
}
