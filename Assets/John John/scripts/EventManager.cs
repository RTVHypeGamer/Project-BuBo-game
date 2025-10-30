using UnityEngine;

public class EventManager : MonoBehaviour
{

    public static EventManager Instance {  get; private set; }

    public DialogueEvent dialogueEvents;




    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Found more than one Game Manager in the scene.");
        }
        Instance = this;

        dialogueEvents = new DialogueEvent();
    }

}
