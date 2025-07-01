using UnityEngine;

public class Jumper:MonoBehaviour
{
    [SerializeField]
    private Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //myRigidbody=GetComponent<Rigidbody>();
        myRigidbody.AddForce(0,500,0);
    }

}
