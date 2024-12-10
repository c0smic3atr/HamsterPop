using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody rb;
    private float verticalInput;
    public GameObject playerCam;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = playerCam.transform.rotation;
    }

    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rb.AddRelativeForce(Vector3.forward * moveSpeed * verticalInput);
    }
}
