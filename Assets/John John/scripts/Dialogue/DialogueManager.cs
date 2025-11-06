using UnityEngine;
using TMPro;
using System.Collections;
using Unity.AppUI.UI;
public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject dialogueBox;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        dialogueBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (textComponent.text == lines[index])
            {
                textComponent.text = lines[index];
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        dialogueBox.SetActive(true);
        textComponent.text = string.Empty;
        index = 0;
        StartCoroutine(TypeLine());
        
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            StartCoroutine(TypeLine());
        }
        else
        {
            textComponent.text = string.Empty;
            StopAllCoroutines();
            dialogueBox.SetActive(false);
        }
    }
}
