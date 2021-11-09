using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    [SerializeField] float Speed = 1000f;
    [SerializeField] float TiltSpeed = 100f;

    Rigidbody rocket;

    void Start()
    {
        rocket = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        float rotZ = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
            rocket.AddForce(transform.up * (Speed * Time.deltaTime));

        if (!Mathf.Approximately(rotZ, 0))
        {
            rocket.freezeRotation = true;
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, 0, rotZ * TiltSpeed * Time.deltaTime));
        }
        rocket.freezeRotation = false;
    }
}
