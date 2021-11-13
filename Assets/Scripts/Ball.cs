using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SphereCollider ballCollider;
    public Collider2D goalCollider;
    private bool touchingGoal;
    public Transform goalTransform;

     

    void Start()
    {
        ballCollider = GameObject.FindGameObjectWithTag("Player1").GetComponent<SphereCollider>();
        goalCollider = GameObject.FindGameObjectWithTag("Goal").GetComponent<Collider2D>();
    }

    void Update()
    {



    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Goal")) { 
            Debug.Log("touched goal");
            transform.position = new Vector3(500, 2, 530);
        }
    }

   
}
