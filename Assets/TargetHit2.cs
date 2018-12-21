using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit2 : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bullet1")
        {
            //Take damage
            Debug.Log("Target 2 Took Damage");
            Destroy(collision.gameObject);
            GetComponent<VirtualButtonScript>().DecreaseSlider();
        }
    }
}
