using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    // Start is called before the first frame update
    bool Flag;
    void Start()
    {
        Transform t = GetComponent<Transform>();
        t.position = new Vector3(20,5,0);
        t.localScale = new Vector3(5, 5, 0);
        Flag = false;
        GetComponent<Renderer>().enabled = Flag;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Flag = !Flag;
            GetComponent<Renderer>().enabled = Flag;
        }

    }
}
