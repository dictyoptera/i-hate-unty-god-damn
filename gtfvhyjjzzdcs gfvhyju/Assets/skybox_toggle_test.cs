using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skybox_toggle_test : MonoBehaviour
{
    public GameObject skybox;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            skybox.SetActive(false);
        }
        else
        {
            skybox.SetActive(true);
        }
    }
}
