using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_buletScript : MonoBehaviour
{
    public Transform impostor;
    public Transform bulet_a;
    [SerializeField] private Transform destination;
    public float gumpForce;
    public float speed;
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.L))
                sr.flipX = false;
        }
        {
            if (Input.GetKey(KeyCode.J))
                sr.flipX = true;
        }
        {
            if (Input.GetKey(KeyCode.K))
                transform.Translate(transform.right * speed *-1);
        }
        {
            if (Input.GetKey(KeyCode.H))
                impostor.position = bulet_a.position;
        }
    }
    public Transform GetDestination()
    { return destination; }
}
