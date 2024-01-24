using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed= 25.0f;
    public float rotationSpeed= 90;
    public float force= 3f;
    public GameObject cannon;
    public GameObject bullet;
    Rigidbody rb;
    Transform t;
    // Transform camTransform;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        t= GetComponent<Transform>();
        
        // camTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)){
            Console.WriteLine("Hello");

            rb.velocity+=this.transform.forward * speed * Time.deltaTime;
        }
            
        else if (Input.GetKey(KeyCode.S))
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            // this.transform.forward=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        }
        else if (Input.GetKey(KeyCode.A)){
            t.rotation *= Quaternion.Euler(0, -rotationSpeed* Time.deltaTime, 0);
            // this.transform.forward=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));

        }
        
        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(t.up * force);
        
        if (Input.GetButtonDown("Fire1")){
            
            GameObject newBullet= GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up *2;
            newBullet.GetOrAddComponent<Rigidbody>().AddForce(newBullet.transform.forward *1500);
            Destroy(newBullet, 5);
        }
    }
}
