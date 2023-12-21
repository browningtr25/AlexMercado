using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public void Start() {
        Invoke("Remove", 8);
    }
    public void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Enemy") {
            Destroy(collider.gameObject);
            this.gameObject.SetActive(false);
            
        }
    }
    public void Remove() {
        this.gameObject.SetActive(false);
    }
}
