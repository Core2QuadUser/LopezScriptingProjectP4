using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }




    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
        // Called every physics step
        // FixedUpdate intervals are consistent
        // Used for regular updates such as:
        // Adjusting physics (Rigidbody) objects
    }
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
    }
}
