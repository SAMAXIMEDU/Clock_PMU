using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    private float ySpeed = 0;
    private bool flagTouch = false;

    private float gravitySpeed = 20f;
    private float minSpeed = -20f;
    private float speed = 10f;

    //private bool esc = false;

    private int width = Screen.width;
    private int height = Screen.height;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ySpeed -= gravitySpeed * Time.deltaTime;

        if (ySpeed < minSpeed)
        {
            ySpeed = minSpeed;
        }

        //if (Input.GetKey(KeyCode.Escape))
        //{
        //    Time.timeScale = 0f;
        //}

        //if (Input.GetKey(KeyCode.Q))
        //{
        //    Time.timeScale = 1f;
        //}

        //if (Input.touchCount > 0 && !flagTouch)
        //{
        //    ySpeed = speed;
        //    flagTouch = true;
        //}

        //if (Input.touchCount == 0)
        //{
        //    flagTouch = false;
        //}

        if (Input.GetKey(KeyCode.Space) && !flagTouch)
        {
            ySpeed = speed;
            flagTouch = true;
        }
        else if (!Input.GetKey(KeyCode.Space))
        {
            flagTouch = false;
        }
        if (transform.position.y < -5 || transform.position.y > 9)
        {
            SingleTone.Restart();
        }

        transform.position += new Vector3(0, ySpeed * Time.deltaTime, 0);

    }

    private void OnTriggerEnter(Collider other)
    {
        SingleTone.Restart();
    }
}
