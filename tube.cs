using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tube : MonoBehaviour
{

    // Start is called before the first frame update
    public static float xSpeed = -8f;
    private bool flag = true;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(xSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x < -(Screen.width / 150))
        {
            transform.position = new Vector3(Screen.width / 150, Random.Range(8, 12), -6.081f);//7.71
            flag = true;
        }

        if (transform.position.x < -5 && flag)
        {
            score.value += 1;
            flag = false;
        }

     
    }
}
