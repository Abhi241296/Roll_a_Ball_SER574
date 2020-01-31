using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float sp = 5;
    private Rigidbody rb;
    private int cnt;
    public Text cnttxt;
    public Text wintxt;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cnt = 0;
        SetCount();
        wintxt.text = "";
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(mH, 0.0f, mV);
        rb.AddForce(move*5);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tiles"))
        {
            other.gameObject.SetActive(false);
            cnt = cnt + 1;
            SetCount();
        }
    }

    void SetCount()
    {
        cnttxt.text = "Score: " + cnt.ToString();
        if(cnt >=9)
        {
            wintxt.text = "Congratulations!";
        }
    }
}
