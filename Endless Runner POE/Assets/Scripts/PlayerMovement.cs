using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 3;
    public float horizontalSpeed = 4;
    

    // Update is called once per frame
    void Update()
    {
        //player speed relative to the game world
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        //Binds movement
        if (Input.GetKey(KeyCode.A))
        
    }
}
