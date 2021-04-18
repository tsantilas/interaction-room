using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCTV : MonoBehaviour
{

    public Transform playerPos;
    public GameObject cctvAlert;

    float zRange1 = -2.5f;
    float zRange2 = 0.0f;
    float xRange1 = -11.0f;
    float xRange2 = 0.0f;
    private void Start()
    {
        cctvAlert.SetActive(false);
    }

    void Update()
    {
        if (playerPos.transform.position.z > zRange1 && playerPos.transform.position.z < zRange2 && playerPos.transform.position.x > xRange1 && playerPos.transform.position.x < xRange2)
        {
            transform.LookAt(playerPos);

            cctvAlert.SetActive(true);
        }
        else
        {
            cctvAlert.SetActive(false);
        }
    } 
}