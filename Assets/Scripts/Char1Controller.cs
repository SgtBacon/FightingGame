using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char1Controller : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float Speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 moveby = transform.right * x + transform.forward * z;

        rb.MovePosition(transform.position + moveby.normalized * Speed * Time.deltaTime);
    }
}