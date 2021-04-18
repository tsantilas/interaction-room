using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Transform Player;
    public GameObject Light;
    public float maxDistance = 2.0f;

    public bool isOn = false;

    private void Start()
    {
        Light.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            LightSwitch();
        }
    }

    void LightSwitch()
    {
        RaycastHit hit;

        if (Physics.Raycast(Player.transform.position, Player.transform.forward, out hit, maxDistance) && hit.transform.tag == "Button")
        {
            if (!isOn)
            {
                Light.SetActive(true);
            }
            else
            {
                Light.SetActive(false);
            }
            isOn = !isOn;
        }
    }
}