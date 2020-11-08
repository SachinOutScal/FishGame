using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{

    [SerializeField] float _speed = 100.0f;  
    Rigidbody rb;
    [SerializeField]GameObject hookExtension;
    



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hookExtension.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (transform.position.y <= 120.0f)
        {
            if (!hookExtension.activeSelf)
            {
              
                hookExtension.SetActive(true);
            }

        }

        if (transform.position.y <= 118)
        {
        
            // run floating animation
            Vector3 rectPos = new Vector3(transform.position.x, 118.0f, transform.position.z);
            transform.position = rectPos; 
        }
       
       
            if (h != 0 || v != 0)
            {
                Vector3 changePos = new Vector3(v, 0, -h) * _speed * Time.deltaTime;
                transform.position += changePos;


            }
    
        
        
       


    }




}

