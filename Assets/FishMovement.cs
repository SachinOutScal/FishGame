using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float rotatingSpeed =10; 
    public float movingSpeed =100; 
    float previousTime;
    public float deltaTime = 2.0f;
    Vector3 newDir;
    Rigidbody rb;
    public List<Transform> waypoints;
    Vector3 currentEulerAngles;
    int i;
    float timeCount; 
    // Start is called before the first frame update
    void Start()
    {
        i = 0; 
        previousTime = Time.time;
        rb = GetComponent<Rigidbody>();
        currentEulerAngles = transform.localEulerAngles;
        newDir = new Vector3(1,0,1);
        timeCount = 0.0f; 
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        //if(collision.gameObject.name == "Terrain")
        //{
        //    newDir = -newDir;

        //}


    }



    // Update is called once per frame
    void Update()
    {
       // rb.velocity = transform.forward * Time.deltaTime * movingSpeed;
        transform.Translate(transform.forward * Time.deltaTime * movingSpeed);


        //transform.rotation = Quaternion.Slerp(transform.rotation, waypoints[i].rotation, timeCount);
        //timeCount += Time.deltaTime; 
        //if (Vector3.Distance(transform.position, waypoints[i].position) > 2f)
        //{
        //    //Quaternion target = Quaternion.LookRotation(newDir, new Vector3(0, 1, 0));
        //    //Quaternion current = transform.localRotation;
          
        //}
        //else
        //{
        //    Debug.Log("reached waypoint"); 

        //}

        
        //if ((Time.time - previousTime) > deltaTime)
        //{
        //    Vector2 dir = Random.insideUnitCircle*100;

        //    newDir = new Vector3(Mathf.Abs(dir.x), 0, Mathf.Abs(dir.y));
          
        //    previousTime = Time.time;

        //}
        //Quaternion target = Quaternion.LookRotation(newDir, new Vector3(0, 1, 0));
        //Quaternion current = transform.localRotation;
        //transform.localRotation = Quaternion.Slerp(current, target, Time.deltaTime);        

    }

 


}


