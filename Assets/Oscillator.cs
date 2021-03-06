using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Start is called before the first frame update
    // first x y 
    Vector3 velY = new Vector3(0, 0, 0);
    [SerializeField]
    [Tooltip("speed")]
    float speed = 0.5f;
    
    [SerializeField]
    [Tooltip("border")]
    float Border = 10f;

    Vector3 curVel = new Vector3(-1, 0, 0);

    [SerializeField]
    [Tooltip("start Psoition")]
    Vector3 Position = new Vector3(0, 0, 0);


    float timer;
    
    void Start()
    {
        Transform t = GetComponent<Transform>();
        t.position= Position;
        timer = 0;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        timer += Time.deltaTime;
        curVel.x = oscillated(timer, speed, Border);
        t.position = (Position+curVel); // startpos.x+[-10....10] = [10*cos(time*speed)
    }

    float oscillated(float time, float speed, float scale)
    {
        return Mathf.Cos(time*speed) * scale;
    }

}
