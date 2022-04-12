using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayserController : MonoBehaviour
{
    //private float speed=0;
    Rigidbody PlayerRB;
    public float JumpForce = 10;
    public float GravityMultiplier;
    public bool isOnTheGround;

    // Start is called before the first frame update
    void Start()
    {
        PlayerRB = GetComponent<Rigidbody>();
        Physics.gravity *= GravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space)&& isOnTheGround)
        {
            PlayerRB.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isOnTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnTheGround = true;
    }
}
