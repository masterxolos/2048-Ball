using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Combine : MonoBehaviour
{
    [SerializeField] private Transform _mounted;
    [SerializeField] private GameObject particle;
    public GameObject[] locations = new GameObject[5];
    public GameObject[] objects = new GameObject[5];
    public int[] objectValues = new int[5];

    [SerializeField] private int lastObject = -1;
    [SerializeField] private int index = -1;
    [SerializeField] GameObject two;
    [SerializeField] GameObject four;
    [SerializeField] GameObject eight;
    [SerializeField] GameObject sixteen;
    [SerializeField] GameObject thirteetwo;
    [SerializeField] GameObject sixtyfour;
    [SerializeField] GameObject onehunderedtwentyeight;
    [SerializeField] GameObject ttwohunderedfiftysix;
    // Start is called before the first frame update
    void Start()
    {
        _mounted = GameObject.Find("Mounted").transform;
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    
    public void ONObjectTouch(GameObject newObject)
    {
        lastObject++;
        index++;
       // int value;
      //  int.TryParse(gameObject.tag,out value);
        objects[index] = newObject;
        switch (newObject.tag)
        {
            case "2":
                objectValues[index] = 2;
                break;
            case "4":
                objectValues[index] = 4;
                break;
            case "8":
                objectValues[index] = 8;
                break;
            case "16":
                objectValues[index] = 16;
                break;
            case "32":
                objectValues[index] = 32;
                break;
            case "64":
                objectValues[index] = 64;
                break;
            case "128":
                objectValues[index] = 128;
                break;
        }
        //bjects[lastObject].transform.DOMove(locations[lastObject].transform.position, 0.1f);
        
        int k = lastObject;
        
        while (k >= 1 )
        {
            
            if (objectValues[k] != objectValues[k - 1])
            {
                k--;
            }
            else
            {
                objects[k].GetComponent<Collider>().enabled = false;
                var newTag = objectValues[k - 1] * 2;
                objectValues[k] = 0;
                objectValues[k-1] = newTag;

                //objects[k].transform.DOMove(locations[k - 1].transform.position, 0.1f);
                Instantiate(particle, objects[k - 1].transform.position, Quaternion.identity);
                //instantiate particle
                Destroy(objects[k]);
                Destroy(objects[k - 1]);
                
                lastObject--;
                index--;
                Debug.Log("k is " + k);
                switch (newTag)
                {
                    case 2: 
                        objects[k-1] = Instantiate(two, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 4:
                        objects[k-1] = Instantiate(four, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 8:
                        objects[k-1] = Instantiate(eight, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 16:
                        objects[k-1] = Instantiate(sixteen, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 32:
                        objects[k-1] = Instantiate(thirteetwo, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 64:
                        objects[k-1] = Instantiate(sixtyfour, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 128:
                        objects[k-1] = Instantiate(onehunderedtwentyeight, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                    case 256:
                        objects[k-1] = Instantiate(ttwohunderedfiftysix, objects[k-1].transform.position, Quaternion.Euler(0, 90, 0));
                        objects[k - 1].GetComponent<CollisionDetector>().isTriggered = true;
                        objects[k-1].GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                        objects[k-1].gameObject.transform.parent = _mounted;
                        break;
                }
                
                Debug.Log(newTag);
                //objects[k - 1].tag = newTag.ToString();

            }
        }
        Debug.Log("a");
        
    }
}
