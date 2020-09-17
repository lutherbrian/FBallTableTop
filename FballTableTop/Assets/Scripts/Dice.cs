using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            float dirx = Random.Range(0, 500);
            float diry = Random.Range(0, 500);
            float dirz = Random.Range(0, 500);
            transform.position = new Vector3(0, transform.position.y + 3, 0);
            
            transform.rotation = Quaternion.identity;
            rb.AddForce(transform.up * 3);
            rb.AddForce(transform.right * Random.Range(-1000, 1000));
            rb.AddForce(transform.forward * Random.Range(-1000, 1000));
            rb.AddTorque(dirx, diry, dirz);
            
        }
    }
}
