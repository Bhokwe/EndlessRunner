using TMPro;
using UnityEngine;


public class EndLevelCheckpoints : MonoBehaviour
{
    //[SerializeField]
    //GameObject UI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //UI.SetActive(true);
        //Might need if scene migrates player to new scene UI = GameObject.Find();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)//
    {
        Debug.Log("Level {Level Counter} Complete!!");//Checkpoint Display
    }
    /*private void OnEnterTrigger(Collider collider) //Player to interact with checkpoint to complete the level
    {
        Debug.Log("Level {Level Counter} Complete!!");//Checkpoint Display

    }*/
    //Checkpoint to behave as teleporter/NewLevelStart
    /*private class CheckpointLevelTeleport(Collision collision)
    {

    }*/
}
