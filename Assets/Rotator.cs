using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Tooltip("speed")]
    float speed;

    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        t.Rotate(0,0,Time.deltaTime*(speed*3));
    }
}
