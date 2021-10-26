using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private Transform _mounted;
    [SerializeField] private Combine _combine;
    
    [SerializeField] GameObject two;
    [SerializeField] GameObject four;
    [SerializeField] GameObject eight;
    [SerializeField] GameObject sixteen;
    [SerializeField] GameObject thirteetwo;
    [SerializeField] GameObject sixtyfour;
    [SerializeField] GameObject onehunderedtwentyeight;
    [SerializeField] GameObject ttwohunderedfiftysix;
    
    GameObject newball;

    private int number;
    // Start is called before the first frame update
    [SerializeField] public bool isTriggered = false;
    
    private BallSpawner _ballSpawner;
    
    void Start()
    {
        _ballSpawner = GameObject.Find("BallSpawner").GetComponent<BallSpawner>();   
        _mounted = GameObject.Find("Mounted").transform;
        _combine = _mounted.gameObject.GetComponent<Combine>();
        
        
        switch (gameObject.tag)
        {
            case "2":
                number = 2;
                break;
            case "4":
                number = 4;
                break;
            case "8":
                number = 8;
                break;
            case "16":
                number = 16;
                break;
            case "32":
                number = 32;
                break;
            case "64":
                number = 64;
                break;
            case "128":
                number = 128;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.transform == _mounted || other.gameObject.transform.parent == _mounted)&& isTriggered == false)
        {
            isTriggered = true; 
            gameObject.transform.parent = _mounted;
            //gameObject.tag = "Mounted";
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            _combine.ONObjectTouch(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("X2"))
        {
            var newTag = number * 2;
            //gameObject.tag = newtag.ToString();
            switch (newTag)
            {
                case 2: 
                        newball = Instantiate(two, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 4:
                        newball = Instantiate(four, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 8:
                        newball = Instantiate(eight, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 16:
                        newball = Instantiate(sixteen, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 32:
                        newball = Instantiate(thirteetwo, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 64:
                        newball = Instantiate(sixtyfour, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 128:
                        newball = Instantiate(onehunderedtwentyeight, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 256:
                        newball = Instantiate(ttwohunderedfiftysix, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                }
            newball.GetComponent<Movement>().isTouched = true;
            newball.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            
            Destroy(gameObject);

        }
        else if (other.gameObject.CompareTag("x4"))
        {
            var newtag = number * 4;
            //gameObject.tag = newtag.ToString();
            switch (newtag)
                {
                    case 2: 
                        newball = Instantiate(two, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 4:
                        newball = Instantiate(four, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 8:
                        newball = Instantiate(eight, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 16:
                        newball = Instantiate(sixteen, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 32:
                        newball = Instantiate(thirteetwo, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 64:
                        newball = Instantiate(sixtyfour, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 128:
                        newball = Instantiate(onehunderedtwentyeight, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 256:
                        newball = Instantiate(ttwohunderedfiftysix, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                }
            newball.GetComponent<Movement>().isTouched = true;
            newball.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("bolu2"))
        {
            if (number != 2)
            {
                var newtag = number / 2;
                //gameObject.tag = newtag.ToString();
                switch (newtag)
                {
                    case 2:
                        newball = Instantiate(two, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 4:
                        newball = Instantiate(four, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 8:
                        newball = Instantiate(eight, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 16:
                        newball = Instantiate(sixteen, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 32:
                        newball = Instantiate(thirteetwo, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 64:
                        newball = Instantiate(sixtyfour, gameObject.transform.position, Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 128:
                        newball = Instantiate(onehunderedtwentyeight, gameObject.transform.position,
                            Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                    case 256:
                        newball = Instantiate(ttwohunderedfiftysix, gameObject.transform.position,
                            Quaternion.Euler(0, 90, 0));
                        gameObject.transform.parent = _mounted;
                        break;
                }
                newball.GetComponent<Movement>().isTouched = true;
                newball.GetComponent<Rigidbody>().velocity = gameObject.GetComponent<Rigidbody>().velocity;
                Destroy(gameObject);
            }
        }
        else if (other.gameObject.CompareTag("spawnNewObject"))
        {
            _ballSpawner.spawnABall();
        }
    }
}
