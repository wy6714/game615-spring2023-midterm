using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    int score = 0;
    public TMP_Text scoreText;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm.createFruits(15);
    }
 
    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        gameObject.transform.Translate(gameObject.transform.forward * Time.deltaTime * moveSpeed * vAxis, Space.World);
        gameObject.transform.Rotate(0, rotateSpeed * Time.deltaTime * hAxis, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("fruits"))
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Pineapple: " + score.ToString();
         
        }
    }
}
