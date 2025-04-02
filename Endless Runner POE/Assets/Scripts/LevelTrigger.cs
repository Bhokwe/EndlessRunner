using System.Collections;
using UnityEngine;

public class LevelTrigger : MonoBehaviour
{
    public GameObject LevelSection1;
    public float delayTime = 3f; // delays the speed of the collider interations
    private bool isCoroutineRunning= false;
    private Collider triggerCollider;

    public float offset = -6;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger")&& !isCoroutineRunning)
        {
            var go = Instantiate(LevelSection1);
            go.transform.position = new Vector3(0,0,offset);
            offset -= 6; 
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trigger"))
        {
            other.enabled = false;
            Debug.Log("Goodbye!");
        }
    }
    IEnumerator DelayedAction()
    {
        isCoroutineRunning = true; //prevents multiple coroutine calls
        Debug.Log("Enter trigger. Waiting...");
        yield return new WaitForSeconds(delayTime);//Delay for specifified time
        Debug.Log("Done waiting.");
        isCoroutineRunning=false; //Reset it to allow future triggers
    }


}
