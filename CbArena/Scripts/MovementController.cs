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
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)){
            trans.position = new Vector3(trans.position.x + 1, trans.position.y, trans.position.z);
        }
        if (Input.GetKeyDown(KeyCode.S)){
            trans.position = new Vector3(trans.position.x -1, trans.position.y, trans.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            trans.position = new Vector3(trans.position.x , trans.position.y, trans.position.z + 1);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            trans.position = new Vector3(trans.position.x, trans.position.y, trans.position.z - 1);
        }
    }
}
