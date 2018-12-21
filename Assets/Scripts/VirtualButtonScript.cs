using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler {

    public GameObject vbBtn;
    public GameObject bullet;
    [SerializeField]
    private int speed = 10;
    public Slider slider;
    public TextMesh buttonText;
    [SerializeField]
    private float health = 1f;

    // Use this for initialization
    void Start () {
        vbBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (buttonText.text == "Restart")
            SceneManager.LoadScene(0);
        Debug.Log("Pressing");
        GameObject tempBullet = Instantiate(bullet, bullet.transform);
        tempBullet.transform.parent = bullet.transform.parent;
        tempBullet.SetActive(true);
        tempBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }

    public void DecreaseSlider ()
    {
        health -= 0.05f;
        slider.value = health;
        if (health <= 0)
        {
            Debug.Log("Done");
            buttonText.text = "Restart";
        }
    }

}
