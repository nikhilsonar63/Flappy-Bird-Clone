using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BirdController : MonoBehaviour
{
    public float speed = 5f;
    public sound sm;
    Rigidbody2D rb;
    public bool isded = false;
    Collider2D coll;
    Animator anim;
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& isded==false)
        {
            sm.play_flay();
            rb.velocity = Vector2.up * speed;
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sm.play_hiit();
        isded = true;
        coll.enabled = false;
        anim.Play("Die");
        rb.velocity = Vector2.up * speed;
        screen.SetActive(true);
    }
  
}
