using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buletScript : MonoBehaviour
{
    [SerializeField] private Transform destination;
    public float gumpForce;
    public float speed;
    public SpriteRenderer sr;
    public Transform rat;
    public Transform bulet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.D))
                sr.flipX = false;
        }
        {
            if (Input.GetKey(KeyCode.A))
                sr.flipX = true;
        }
        {
            if (Input.GetKey(KeyCode.S))
                transform.Translate(transform.right * speed);
        }
        {
            if (Input.GetKeyUp(KeyCode.S))
                rat.position = bulet.position;
        }
    }
    public Transform GetDestination()
    { return destination; }
}


