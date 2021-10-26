using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float jumpHight;

    private void Awake()
    {
        Initialize();
    }
    private void Initialize()
    {
    }

    private void OnTriggerEnter(Collider target)
    {
        //FindObjectOfType<AudioManager>().Play("BallSound");

        int choosenSide = Random.Range(0, 2);
        if (choosenSide == 0)
            target.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1 * (jumpHight / 10), jumpHight, 0));
        else if (choosenSide == 1)
            target.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-1 * (jumpHight / 10), jumpHight, 0));
    }
}
