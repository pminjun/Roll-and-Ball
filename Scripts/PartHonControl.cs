using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartHonControl : MonoBehaviour
{
    int a = 1;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -19.0f)
        {
            a = 1;
        }
        else if(transform.position.y > -17.0f)
        {
            a = -1;
        }

        transform.Translate(Vector3.up * Random.Range(0, 30) * Time.deltaTime * a);
    }
}
