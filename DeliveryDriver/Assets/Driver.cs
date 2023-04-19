using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 2f;
    [SerializeField] float moveSpeed = 0.04f;


    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerSpeed;
        float moveamount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0,0, -steeramount);
        transform.Translate(0,moveamount,0);
    }
}
