using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    public TMP_Text timeText;
    private float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(horizontalMove * speed, 0, verticalMove * speed));

        time += Time.deltaTime;

    }

    void DisplayTime(float timeDisplayed)
    {
        float minutes = Mathf.FloorToInt(timeDisplayed / 60);
        float seconds = Mathf.FloorToInt(timeDisplayed % 60);

        timeText.text = string.Format("Time Elapsed: {0:00}:{1:00}", minutes, seconds);
    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // EXERCISE 2.7.2: Create OnCollisionExit function below

    // EXERCISE 2.7.3: Create OnCollisionStay function below 
}
