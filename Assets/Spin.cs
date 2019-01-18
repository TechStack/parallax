using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

   public float speed = 1; 
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), speed * Time.deltaTime);
    }
}
