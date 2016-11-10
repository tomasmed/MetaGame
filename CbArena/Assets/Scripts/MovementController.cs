using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
    public Rigidbody rb;
    public Transform trans;
    public float speed;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        print("Tomas smells like eggs");
	}
	
	// Update is called once per frame
	void Update () {
        print("I'm a chunky monkey from funky town");
        if (Input.GetKeyDown(KeyCode.W)){
            if (!Physics.Raycast(trans.position, Vector3.right, 1,1,QueryTriggerInteraction.Ignore))
            {
                trans.position = new Vector3(trans.position.x + 1, trans.position.y, trans.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.S)){
            if (!Physics.Raycast(trans.position, Vector3.left, 1,1, QueryTriggerInteraction.Ignore))
            {
                trans.position = new Vector3(trans.position.x - 1, trans.position.y, trans.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.A)){
            if (!Physics.Raycast(trans.position, Vector3.forward, 1,1, QueryTriggerInteraction.Ignore))
            {
                trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z + 1);
            }
        }
        if (Input.GetKeyDown(KeyCode.D)){
            if (!Physics.Raycast(trans.position, Vector3.back, 1,1, QueryTriggerInteraction.Ignore))
            {
                trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
            }
        }
    }
}
