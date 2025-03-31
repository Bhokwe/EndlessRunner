using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 3;
    public float horizontalSpeed = 4;
    public float leftLimit = -3;
    public float rightLimit = 3;
    

    // Update is called once per frame
    void Update()
    {
        //player speed relative to the game world
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        //Binds movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            } 

        }
    }
}
