using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject Player1;
    [SerializeField] private GameObject Player2;
    DashState state;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float movementSpeed=2f;
    public Animator animatorP1;
    public Animator animatorP2;
    void Update()
    {
        if (Player1 && Player2)
        {
            if(Player1.GetComponent<Rigidbody2D>().velocity.x != 0 || Player1.GetComponent<Rigidbody2D>().velocity.y != 0 || Player2.GetComponent<Rigidbody2D>().velocity.x != 0 || Player2.GetComponent<Rigidbody2D>().velocity.y != 0)
            {
                StepSounder.PlaySound("stepongrass");
                //Debug.Log("Hareket Ediyor!");
            }
            
            //player1
            if (state != DashState.Dashing)
            {
            horizontalInput = Input.GetAxisRaw("HorizontalP1");

            Player1.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalInput * movementSpeed, Player1.GetComponent<Rigidbody2D>().velocity.y);
            
            verticalInput = Input.GetAxisRaw("VerticalP1");
            Player1.GetComponent<Rigidbody2D>().velocity = new Vector2(Player1.GetComponent<Rigidbody2D>().velocity.x, verticalInput * movementSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animatorP1.SetBool("walkingLeft", true);
                animatorP1.SetBool("walkingRight", false);
            }
            else
            {
                animatorP1.SetBool("walkingLeft", false);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                animatorP1.SetBool("walkingLeft", false);
                animatorP1.SetBool("walkingRight", true);
            }
            else
            {
                animatorP1.SetBool("walkingRight", false);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                animatorP1.SetBool("walkingTop", true);
            }
            else
            {
                animatorP1.SetBool("walkingTop", false);
            }


            //player2
            horizontalInput = Input.GetAxisRaw("HorizontalP2");
            Player2.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalInput * movementSpeed, Player2.GetComponent<Rigidbody2D>().velocity.y);
            
            verticalInput = Input.GetAxisRaw("VerticalP2");
            Player2.GetComponent<Rigidbody2D>().velocity = new Vector2(Player2.GetComponent<Rigidbody2D>().velocity.x, verticalInput * movementSpeed);

            if (Input.GetKey(KeyCode.A))

            {
                animatorP2.SetBool("walkingLeft", true);
                animatorP2.SetBool("walkingRight", false);
            }
            else
            {
                animatorP2.SetBool("walkingLeft", false);
            }
            if (Input.GetKey(KeyCode.D))
            {
                animatorP2.SetBool("walkingLeft", false);
                animatorP2.SetBool("walkingRight", true);
            }
            else
            {
                animatorP2.SetBool("walkingRight", false);
            }

            if (Input.GetKey(KeyCode.W))
            {
                animatorP2.SetBool("walkingTop", true);
            }
            else
            {
                animatorP2.SetBool("walkingTop", false);
            }
        }
    }
}
