using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(5f * Time.deltaTime, 5f * Time.deltaTime, 0);
    }
}
