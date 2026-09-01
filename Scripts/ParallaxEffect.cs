using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect: MonoBehaviour
   
{
    public float speed;
    Vector3 starposition;
    public float endpoint;
    // Start is called before the first frame update
    void Start()
    {
        starposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<= endpoint)
        {
            transform.position = starposition;
        }
        transform.position +=Vector3.left * speed * Time.deltaTime;
    }
}
