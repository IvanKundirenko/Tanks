using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impostorScript : MonoBehaviour
{
    public GameObject destroyedEffect;
    public SpriteRenderer sr;
    public float gumpForce;
    public Rigidbody2D rb;
    public float speed;
    public Transform bulet;
    public void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            //transform.Translate(transform.right * speed * Time.deltaTime);
            rb.velocity = new Vector2(speed, rb.velocity.y);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.J))
        {
            //transform.Translate(transform.right * speed * Time.deltaTime * -1);
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            rb.AddForce(transform.up * gumpForce, ForceMode2D.Impulse);
        }
                     
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bulet"))
            Instantiate(destroyedEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
