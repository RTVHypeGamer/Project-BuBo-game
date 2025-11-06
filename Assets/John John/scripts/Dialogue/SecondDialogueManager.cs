using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SecondDialogueManager : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public GameObject dialogueBox;

    Message[] currentMessages;
    int activeMessage = 0;
    public static bool isActive = false;

    public void OpenDialogue(Message[] messages)
    {
        currentMessages = messages;
        activeMessage = 0;
        isActive = true;

        Debug.Log("Started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
        dialogueBox.LeanScale(Vector3.one, 0.5f).setEaseInOutExpo();
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;


    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        }
        else
        {
            Debug.Log("Conversation ended");
            dialogueBox.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
            isActive = false;
        }
    }


    private void Start()
    {
        dialogueBox.transform.localScale = Vector3.zero;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && isActive == true)
        {
            NextMessage();
        }
    }
}