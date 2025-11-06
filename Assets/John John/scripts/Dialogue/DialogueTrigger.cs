using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;


    public void StartDialogue()
    {
        Object.FindFirstObjectByType<SecondDialogueManager>().OpenDialogue(messages);
    }
}

[System.Serializable]
public class Message
{
    public string message;
}

