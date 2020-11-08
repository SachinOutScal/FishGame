using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishRot : MonoBehaviour
{
    public Transform target;
    public float rotSpeed = 10.0f; 

    void Update()
    {
        Vector3 relativePos = target.position - transform.position;

      
        Quaternion neededRotation = Quaternion.LookRotation(relativePos, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, neededRotation, Time.deltaTime * rotSpeed);
    
    }


}

