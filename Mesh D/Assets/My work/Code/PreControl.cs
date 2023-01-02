using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreControl : MonoBehaviour
{
    public GameObject PreSoildSnowMan;
    public GameObject PreSoildBridge1;
    public GameObject PreSoildBridge2;
    public GameObject PreSoildBridge3;

    public GameObject PreBrokenSnowMan;
    public GameObject PreBrokenBridge1;
    public GameObject PreBrokenBridge2;
    public GameObject PreBrokenBridge3;

    // Start is called before the first frame update
    void Start()
    {
        PreSoildSnowMan.SetActive(true);
        PreSoildBridge1.SetActive(true);
        PreSoildBridge2.SetActive(true);
        PreSoildBridge3.SetActive(true);

        PreBrokenSnowMan.SetActive(false);
        PreBrokenBridge1.SetActive(false);
        PreBrokenBridge2.SetActive(false);
        PreBrokenBridge3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PreSoildSnowMan.SetActive(false);
            PreSoildBridge1.SetActive(false);
            PreSoildBridge2.SetActive(false);
            PreSoildBridge3.SetActive(false);

            PreBrokenSnowMan.SetActive(true);
            PreBrokenBridge1.SetActive(true);
            PreBrokenBridge2.SetActive(true);
            PreBrokenBridge3.SetActive(true);
        }
    }
}
