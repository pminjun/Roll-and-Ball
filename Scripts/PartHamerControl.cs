using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartHamerControl : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Random.Range(100, 200) * Time.deltaTime);
    }
}
