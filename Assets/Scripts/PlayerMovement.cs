using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce;
    public float sideWaysForce;
    public Rigidbody playerbody;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

    }
    void FixedUpdate()
    {
        playerbody.AddForce(0,0,forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            GoRight();
        }

        if (Input.GetKey("a"))
        {
            GoLeft();
        }
        if (playerbody.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    public void GoRight()
    {
        playerbody.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //playerbody.velocity = new Vector3(sideWaysForce * Time.deltaTime, playerbody.velocity.y, playerbody.velocity.z);
    }
    public void GoLeft()
    {
        playerbody.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //playerbody.velocity = new Vector3(-sideWaysForce * Time.deltaTime, playerbody.velocity.y, playerbody.velocity.z);
    }
}