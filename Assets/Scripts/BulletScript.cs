using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("DestroyBullet");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DestroyBullet ()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
        Debug.Log("Destroyed Bullet");
    }
}
