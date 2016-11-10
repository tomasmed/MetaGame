using UnityEngine;
using System.Collections;

public class PathCreator : MonoBehaviour {

    public bool isinhabited = false;
    public GameObject floor_piece;
    

	// Use this for initialization
	void Start () {
        isinhabited = false;
	}
	
	// Update is called once per frame
	void Update () {
        

        if (transform.position.y < 0){
            this.transform.position = Vector3.Lerp(transform.position,new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Time.deltaTime);
        }



        if (Input.GetKeyDown(KeyCode.E) && isinhabited){
            switch (gameObject.name)
            {
                case "Cube0":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z + 2) , transform.rotation);
                    break;
                case "Cube1":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z), transform.rotation);
                    break;
                case "Cube2":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x + 2, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    break;
                case "Cube3":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x , transform.position.y - 1, transform.position.z + 2), transform.rotation);
                    break;
                case "Cube5":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z - 2), transform.rotation);
                    break;
                case "Cube6":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x -2, transform.position.y - 1, transform.position.z +2 ), transform.rotation);
                    break;
                case "Cube7":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x -2, transform.position.y - 1, transform.position.z), transform.rotation);
                    break;
                case "Cube8":
                    GameObject.Instantiate(floor_piece, new Vector3(transform.position.x -2, transform.position.y - 1, transform.position.z-2), transform.rotation);
                    break;
            }
        }

	}

void OnTriggerEnter(Collider coll){
        if (coll.gameObject.tag.Equals("Player")) {
            isinhabited = true;
        }
    }

void OnTriggerExit(Collider coll){
        if (coll.gameObject.tag.Equals("Player")){
            isinhabited = false;
        }
    }

}



