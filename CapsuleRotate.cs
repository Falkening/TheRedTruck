using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotate : MonoBehaviour
{

    public float xAngle, yAngle, zAngle;


    private GameObject Capsule;




    void Awake()
    {


        Capsule = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Capsule.transform.position = new Vector3(0.75f, 0.0f, 0.0f);
        Capsule.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        Capsule.GetComponent<Renderer>().material.color = Color.red;
        Capsule.name = "Self";

    }


    // Update is called once per frame
    void Update()
    {
        Capsule.transform.Rotate (xAngle, yAngle, zAngle, Space.Self); 





        
    }
}
