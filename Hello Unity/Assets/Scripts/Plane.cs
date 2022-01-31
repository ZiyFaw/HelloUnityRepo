using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    public GameObject twinPlane;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(1, 3);
        if (rand == 1)
        {
            this.tag = "Break";
        } else if (rand == 2)
        {
            twinPlane.tag = "Break";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
