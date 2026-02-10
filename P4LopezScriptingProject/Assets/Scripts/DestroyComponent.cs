using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{

    MeshRenderer mymesh;
    bool status;
    // Start is called before the first frame update
    void Start()
    {
        mymesh = GetComponent<MeshRenderer>();
        status = mymesh.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            bool status = mymesh.enabled;
            mymesh.enabled = !status;
            //Destroy(GetComponent<MeshRenderer>());

        }
    }
}
