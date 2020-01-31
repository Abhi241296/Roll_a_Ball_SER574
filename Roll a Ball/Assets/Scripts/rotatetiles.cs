using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetiles : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(10, 20, 30) * Time.deltaTime);
    }
}
