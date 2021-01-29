using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFinalContrl : MonoBehaviour
{
    int a = 1;
    void Update()
    {
        if (transform.position.y < 2.2f)
        {
            a = 1;
        }
        else if (transform.position.y > 4.5f)
        {
            a = -1;
        }

        transform.Translate(Vector3.up * Random.Range(0, 7) * Time.deltaTime * a);
    }
}
