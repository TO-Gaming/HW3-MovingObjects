using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beating : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Tooltip("speed")]
    float scale = 2f;
    float timer;
    [SerializeField]
    [Tooltip("speed")]
    float rate;
    void Start()
    {
        timer = 0;
        rate = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        timer += Time.deltaTime;
        float x;
        x = Beater(timer,rate,scale)*0.1f;
        t.localScale = new Vector3(x,x,0);
    }

    float Beater(float time, float speed, float scale)
    {
        return Mathf.Abs(Mathf.Cos(time * speed) * scale);
    }
}
