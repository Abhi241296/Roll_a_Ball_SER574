using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Player;
    private Vector3 ofst;

    void Start()
    {
        ofst = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Player.transform.position + ofst;
    }
}
