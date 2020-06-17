using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera MainCamera;
    public GameObject player;

    void Update()
    {
        MainCamera.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
