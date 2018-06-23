using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBattle : MonoBehaviour {
    private bool isPlayerInGrass = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player")) {
            Debug.Log("you're now in grass");
            isPlayerInGrass = true;
            StartCoroutine(randomChanceToStartFight());
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player")) {
            Debug.Log("you're now leaving grass");
            isPlayerInGrass = false;
        }
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
       
    }


    IEnumerator randomChanceToStartFight() {
        while (isPlayerInGrass == true) {
            int num = Random.Range(1,100+1);
            if (num > 93) {
                Debug.Log("pokemon fight starts!");
                SceneManager.LoadScene("_battleScene_");
            }
            yield return new WaitForSeconds(0.7F);
        }

    }
}
