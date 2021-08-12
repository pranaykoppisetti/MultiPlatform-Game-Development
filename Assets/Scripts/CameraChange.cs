using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;
    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }
            StartCoroutine(ModeChange());
        }
    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0) // This is the default camera view mode
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if(CamMode == 1) // Camera view would be changed when pressed C once
        {
            FarCam.SetActive(true);
            NormalCam.SetActive(false);
        }
        if(CamMode == 2)// Camera view would be changed to this when pressed C twice
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
        }
    }
}
