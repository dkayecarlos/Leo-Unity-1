using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
   //ball speed
   public float speed = 10f;
   //player's score
   private int score = 0;
   //UI score text
   public TextMeshProUGUI scoreText;
   
   // Start is called before the first frame update
   void Start()
   {
       //Adding force to our ball when the game is initiated
       GetComponent<Rigidbody>().AddForce(new Vector3(50, 500, 50));
   }
 
   // Update is called once per frame
   void Update()
   {
       //create variables that handle user input
       float horizontalMove = Input.GetAxis("Horizontal");
       float verticalMove = Input.GetAxis("Vertical");
 
       //apply direction to the ball using the variables we created above
       GetComponent<Rigidbody>().AddForce(new Vector3(horizontalMove * speed, 0, verticalMove * speed));
 
   }
 
   void OnTriggerEnter()
   {
       //when ball hits cube update score by 10
       score = score + 10;
       scoreText.text = "Score: " + score;
   }
}
