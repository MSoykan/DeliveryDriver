using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 20;


    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0, -steeramount);
        transform.Translate(0,moveamount,0);
    }
}
