using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partSpliceControl : MonoBehaviour
{
    void Update()
    {
        if(tag == "slice")
        {
            transform.Rotate(Vector3.up * Random.Range(100, 200) * Time.deltaTime);
        }
        if(tag == "sky")
        {
            transform.Rotate(Vector3.up * 5 * Time.deltaTime);
        }
    }
}
