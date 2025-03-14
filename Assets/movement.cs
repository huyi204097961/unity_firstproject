using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 3f;
    public Rigidbody2D rb;
    private Vector2 dir;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + dir * movespeed * Time.fixedDeltaTime);
        animator.SetFloat("speed", dir.magnitude);
        if(dir.x>0)
        transform.localScale = new Vector2(1, 1);
        else if (dir.x < 0)
        transform.localScale = new Vector2(-1, 1);
        
    }
}
