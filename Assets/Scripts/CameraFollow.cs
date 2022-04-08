using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    void LateUpdate()
    {
        
        if (PlayerController.PlayerCurrentPositionY > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, PlayerController.PlayerCurrentPositionY, transform.position.z);
        }
    }
}
