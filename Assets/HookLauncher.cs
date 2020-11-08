using System.Collections;
using UnityEngine;

public class HookLauncher : MonoBehaviour
{
    int _count;
    Rigidbody rb;
    float startTime;
    float endTime;
  [SerializeField] float forceMagnitude = 100;
    float initTime; 
    // Start is called before the first frame update
    void Start()
    {
        _count = 0;
        initTime = Time.time; 
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
             startTime = Time.time; 
            

        }
        if( Input.GetKeyUp(KeyCode.Space))
        {
             endTime = Time.time;           

        }
        float deltaTime = endTime - startTime; 
        if (deltaTime > 0)
        {
            deltaTime = (deltaTime >= 10.0f) ? 10.0f : deltaTime;  // capping maximum force
            Debug.Log("Deltatime " +transform.forward * deltaTime * forceMagnitude);
            rb.AddForce(new Vector3(1,0,0) * deltaTime * forceMagnitude, ForceMode.VelocityChange);
            rb.AddForce(new Vector3(0, -500, 0), ForceMode.Acceleration); 
            rb.useGravity = true; 
            deltaTime = 0; startTime = 0; endTime = 0; 
        }

     


    }
}
