using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyRotation : MonoBehaviour
{
    public AIPath aipath;
    void Update()
    {
        if(aipath.desiredVelocity.x >= 0.1f)
        {
            transform.localRotation = Quaternion.Euler(0,0,0);
        }
        else if (aipath.desiredVelocity.x <= -0.1f)
        {
            transform.localRotation = Quaternion.Euler(0,180,0);
        }
        else if(aipath.desiredVelocity.y >= 0.5f)
        {
            transform.localRotation = Quaternion.Euler(0,0,90);
        }
        else if (aipath.desiredVelocity.y <= -0.5f)
        {
            transform.localRotation = Quaternion.Euler(0,0,-90);
        }
    }
}
