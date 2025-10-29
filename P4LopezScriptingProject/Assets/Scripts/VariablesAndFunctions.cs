using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{

    //create my integer variable
    public int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
        //run my variable tthru my function
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //create the multiply by two function
    int MultiplyByTwo(int number)
    {
        //create a local variable
        int result;
        //multiplying num by 2
        result = number * 2;
        //return the value
        return result;
    }
}
