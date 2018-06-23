using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {
    // Use this for initialization
    public static bool canPlayerMove = true;
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (canPlayerMove) {
            if (Input.GetKey(KeyCode.A)) {
                gameObject.GetComponent<Transform>().Translate(new Vector3(-0.04F, 0, 0));
            }
            if (Input.GetKey(KeyCode.D))
            {
                gameObject.GetComponent<Transform>().Translate(new Vector3(0.04F, 0, 0));
            }
            if (Input.GetKey(KeyCode.W))
            {
                gameObject.GetComponent<Transform>().Translate(new Vector3(0, 0, 0.04F));
            }
            if (Input.GetKey(KeyCode.S))
            {
                gameObject.GetComponent<Transform>().Translate(new Vector3(0, 0, -0.04F));
            }
        }
    }
    private bool canTalkToNpc = false;
}
