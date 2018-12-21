using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit1 : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "bullet2")
        {
            //Take damage
            Debug.Log("Target 1 Took Damage");
            Destroy(collision.gameObject);
            gameObject.GetComponent<VirtualButtonScript>().DecreaseSlider();
        }
    }
}
