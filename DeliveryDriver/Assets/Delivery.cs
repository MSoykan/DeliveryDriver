using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
        [SerializeField] Color32 hasPackageColor = new Color32 ( 1, 1, 1, 1);
        [SerializeField] Color32 deliverPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage = false;

    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Colliding with sth!!");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag== "Package" && !hasPackage)
        {
            Debug.Log("Package picked up.");
            hasPackage=true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, 0.5f);
        }

        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage=false;
            spriteRenderer.color= deliverPackageColor;
        }
    }
}
