using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{


    public Rigidbody rb;
    float dirX;
    private float moveSpeed;
    public float forwardForce = 2000f;
    public float sidewaysFore = 5000f;

    // Start is called before the first frame update
    void Start()
    {
        //rb.AddForce(0, 200, 500);
        // rb = GetComponent<Rigidbody>();

    }
    //void Update()
    // {
    //  dirX = Input.acceleration.x * moveSpeed;
    //  transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    // }

    // Update is called once per frame
    void Update()

    {
        //Vector3 dir = Vector3.zero;
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        // dir.z = Input.acceleration.x;

        // if (dir.sqrMagnitude > 1)
        //  dir.Normalize();

        // dir *= Time.deltaTime;
        // transform.Translate(dir * moveSpeed);



        // dirX = Input.acceleration.x * moveSpeed;
        // transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);



        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:

                    if (touch.position.x > Screen.width / 2)
                        rb.AddForce(sidewaysFore * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                        // rb.velocity = new Vector2(-moveSpeed, 0f);

                    if (touch.position.x < Screen.width / 2)
                       rb.AddForce(-sidewaysFore * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                        //rb.velocity = new Vector2(moveSpeed, 0f);
                    break;

                case TouchPhase.Ended:
                    if (rb.position.y < -1f)
                    {
                        FindObjectOfType<GameManager>().EndGame();

                    }
                    break;

                   
            }





            /*




                     if (Input.GetAxis("Horizontal")>0.3f)
                      {
                      rb.AddForce(sidewaysFore * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                  }
                    if (Input.GetAxis("Horizontal")< -0.3f)
                    {
                      rb.AddForce(-sidewaysFore * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    }

                  if(rb.position.y < -1f)
                  {
                      FindObjectOfType<GameManager>().EndGame();

                  }

        */


        }


    }
}
