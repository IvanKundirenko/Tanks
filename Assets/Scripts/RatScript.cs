using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    public SpriteRenderer sr;
    public float gumpForce;
    public Rigidbody2D rb;
    public float speed;
    public void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(transform.right * speed * Time.deltaTime);
            rb.velocity = new Vector2(speed, rb.velocity.y);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(transform.right * speed * Time.deltaTime * -1);
             rb.velocity = new Vector2 (-speed, rb.velocity.y);
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.up * gumpForce, ForceMode2D.Impulse);

        }





    }


}