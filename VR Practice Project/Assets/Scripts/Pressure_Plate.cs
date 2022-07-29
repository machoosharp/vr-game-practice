using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate : MonoBehaviour
{

    // TODO: runnable would be a script or function imported from another object
    // to allow the pressure plate to control/toggle that script
    public int runnable;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: This should run only when an object tagged player or weight steps on it.
        print(runnable);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
