using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_pipe : MonoBehaviour
{
    public float movespeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        
    }
}
