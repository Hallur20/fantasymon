using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointerChooseOption : MonoBehaviour {
    private string option = "attack";
    private bool canUserPointer = false;
    private bool canDoStuff = false;
    public Text log;
    public GameObject tellToPushF;
    public GameObject attacks;

	// Use this for initialization
	void Start () {
        log.text = "a wild pokemon appears!";
	}

    IEnumerator smallCanChooseCoolDown() {
        yield return new WaitForSeconds(0.6F);
        canDoStuff = true;
    }

    // Update is called once per frame
    void Update() {
        if (canUserPointer == false && Input.GetKeyDown(KeyCode.F)) {
            canUserPointer = true;
            tellToPushF.SetActive(false);
            log.text = "what will you do?";
            StartCoroutine(smallCanChooseCoolDown());
        }
        if (canUserPointer == true) {
        //if upperleft and click s
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(50, -150) && Input.GetKeyDown(KeyCode.S)) {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(50, -392);
            option = "item";
        }
        //if upperleft and click d
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(50, -150) && Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(655, -150);
            option = "switch";
        }
        //if upperright and click a
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(655, -150) && Input.GetKeyDown(KeyCode.A)) {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(50, -150);
            option = "attack";
        }
        //if upperright and click s
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(655, -150) && Input.GetKeyDown(KeyCode.S))
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(655, -392);
            option = "run";
        }
        //if lowerleft and click w
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(50, -392) && Input.GetKeyDown(KeyCode.W)) {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(50, -150);
            option = "attack";
        }
        //if lowerleft and click d
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(50, -392) && Input.GetKeyDown(KeyCode.D))
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(655, -392);
            option = "run";
        }
        //if lowerright and click a
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(655, -392) && Input.GetKeyDown(KeyCode.A)) {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(50, -392);
            option = "item";
        }
        //if lowerright and click w
        if (gameObject.GetComponent<RectTransform>().anchoredPosition == new Vector2(655, -392) && Input.GetKeyDown(KeyCode.W)) {
            gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(655, -150);
            option = "switch";
        }
        if (option.Equals("attack") && Input.GetKeyDown(KeyCode.F) && canDoStuff) {
                attacks.SetActive(true);
                log.text = "g to go back";
        }
            if (option.Equals("attack") && Input.GetKeyDown(KeyCode.G) && attacks.activeSelf == true) {
                attacks.SetActive(false);
                log.text = "what will you do?";
            }
        if (option.Equals("switch") && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("we are switching lol");
        }
        if (option.Equals("item") && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("we are using item lol");
        }
        if (option.Equals("run") && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("_test_");
        }
        }
    }
}
