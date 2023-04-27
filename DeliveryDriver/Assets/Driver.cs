using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 20;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0, -steeramount);
        transform.Translate(0,moveamount,0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Boost"){
            moveSpeed=boostSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed=slowSpeed;
    }
}
