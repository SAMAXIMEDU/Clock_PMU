using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int value = 0;

    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.transform.position = new Vector3(Screen.width/2, Screen.height - 50, 0);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {value}";
    }
}
