using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundObject : MonoBehaviour
{

    //Gemessen in Winkel pro Sekunde
    public float rotationSpeed;
    public GameObject otherObject;

    // Update is called once per frame
    void Update()
    {
        //Rotiere um die gegebene Achse (0,1,0) an der Position des anderen Objekts
        transform.RotateAround(otherObject.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
