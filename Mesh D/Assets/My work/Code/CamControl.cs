using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{

    public GameObject Cam1;
    public GameObject Cam2;

    void Start()
    {
        Cam1.SetActive(true);
        Cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            Cam1.SetActive(true);
            Cam2.SetActive(false);
            print("Cam 1 active");
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            Cam1.SetActive(false);
            Cam2.SetActive(true);
            print("Cam 2 active");
        }
    }
}
