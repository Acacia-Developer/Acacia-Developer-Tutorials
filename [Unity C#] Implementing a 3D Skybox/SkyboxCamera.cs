using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxCamera : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private float skyboxScale;


    private void Update()
    {
        transform.rotation = playerCamera.rotation;
        transform.localPosition = playerCamera.position / skyboxScale;
    }

}
