using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NpcMessages : MonoBehaviour
{
    public GameObject ui;
    public GameObject text;
    private bool playerTalks = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.ToLower().Contains("player") && gameObject.name.ToLower().Contains("npc"))
        {
            playerTalks = true;
            string message = gameObject.GetComponent<Text>().text;
            StartCoroutine(sendMessage(message));
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name.ToLower().Contains("player"))
        {
            ui.SetActive(false);
            playerTalks = false;
            text.GetComponent<Text>().text = "";
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator sendMessage(string message)
    {
        while (playerTalks == true)
        {
            if (Input.GetKeyDown(KeyCode.F) && movePlayer.canPlayerMove == true)
            {
                movePlayer.canPlayerMove = false;
                ui.SetActive(true);
                text.GetComponent<Text>().text = message;

            } else if (Input.GetKeyDown(KeyCode.F) && movePlayer.canPlayerMove == false) {
                movePlayer.canPlayerMove = true;
                ui.SetActive(false);
            }
            yield return null;
        }
    }
}
