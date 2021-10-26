using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Movement : MonoBehaviour {
    //Touch Settings
    [SerializeField] bool isTouching;
    [SerializeField] public bool isTouched;
    private bool isrbadded = false;
    float touchPosX;
    Vector3 direction;
    [SerializeField] private float controlSpeed;

    private Vector3 startPos;
    
    private Rigidbody rb;

    private BallSpawner _ballSpawner;
    //todo istouched etkin olduğu için kapılardan geçince tekrardan hareket edebiliyoruz
    //todo touchphase.ended olmadan önce spawn olmıycak
    void Start()
    {
        _ballSpawner = GameObject.Find("BallSpawner").GetComponent<BallSpawner>();   
        Destroy(gameObject.GetComponent<Rigidbody>());
    }

    void Update()
    {
        if (Input.touchCount > 0 && isTouched != true)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;
                
                case TouchPhase.Moved:
                    transform.position = new Vector3(
                        transform.position.x + touch.deltaPosition.x * Time.deltaTime,
                        transform.position.y, transform.position.z);
                    break;

                case TouchPhase.Ended:
                    gameObject.AddComponent<Rigidbody>();
                    gameObject.GetComponent<Rigidbody>().mass = 0.6f;
                    isTouched = true;
                    isrbadded = true;
                    break;
            }
        }
        else if (isTouched == true && isrbadded == false)
        {
            gameObject.AddComponent<Rigidbody>();
            gameObject.GetComponent<Rigidbody>().mass = 0.6f;
            isrbadded = true;
            
        }
        
    }
/*
    private void FixedUpdate()
    {
        if (isTouching)
        {
            touchPosX += Input.GetAxis("Mouse X") * controlSpeed * Time.fixedDeltaTime;
            isTouched = true;
        }
        else
        {
            
        }

        /*
         //sağa sola flip kodu
        if (Input.GetAxis("Mouse X") > 0)
        {
            transform.rotation = Quaternion.Euler(0.0f,0,0);
        }
        else if (Input.GetAxis("Mouse X") < 0)
        {
            transform.rotation = Quaternion.Euler(0.0f,170,0);
        }
        

        //transform.rotation = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*30, Vector3.forward);
        //  transform.rotation = Quaternion.Euler(0.0f,0.0f,touchPosX*30);
        
    }

    void GetInput()
    {
        if (Input.GetMouseButton(0))
        {
            isTouching = true;
        }
        else
        {
            isTouching = false;
        }
    }
*/
}
 
 