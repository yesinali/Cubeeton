using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Transform transform;

    public Vector3 ReturnEndPoint()
    {
        Vector3 calculatedEndPoint;
        calculatedEndPoint.z = //1
            transform.localScale.z 
            + this.transform.position.z+39;
        calculatedEndPoint.y = 1;
        calculatedEndPoint.x= 0;

        return calculatedEndPoint;
    }
}
