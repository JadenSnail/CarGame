using System.Security.Cryptography;
using UnityEngine;

public class PlayerControlle : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float horizontalInput;
    private float forwardInput ;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, horizontalInput  * Time.deltaTime * turnSpeed);        
    }

}
