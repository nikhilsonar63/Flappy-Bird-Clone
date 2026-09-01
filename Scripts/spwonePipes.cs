using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwonePipe : MonoBehaviour
{
    public GameObject pipe;
    public float spwone_time;
    float timer;
    public float hight;
    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spwone_time)
        {
            timer = 0;
            spwone_pipee();
        }
    }
    private void spwone_pipee()
    {
        Instantiate(pipe, transform.position + new Vector3(0,Random.Range(-hight,hight),0),Quaternion.identity);
    }
}
