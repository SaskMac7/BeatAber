using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePos : MonoBehaviour
{
    public float speedRotate;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, speedRotate * Time.deltaTime, 0);
    }
}
