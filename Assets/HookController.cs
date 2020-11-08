using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookController : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "Fish")
        {
            other.gameObject.SetActive(false); 
            GameManager.Instance.OnFishCatch(); 
        }
    }

}
