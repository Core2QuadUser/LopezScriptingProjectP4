using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTopRotation : MonoBehaviour
{
    public Camera camera = Camera.main;

    public GameObject turret;
    float smooth = 5.0f;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        float angle = Vector3.Angle(camera.transform.forward, ray.direction);

        Quaternion target = Quaternion.Euler(0, angle, 0);
        turret.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
