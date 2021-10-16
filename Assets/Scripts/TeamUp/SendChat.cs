using UnityEngine;
using UnityEngine.UI;

public class SendChat : MonoBehaviour
{
    private InputField inputField => GetComponent<InputField>();
    [SerializeField] private Transform messageBox;
    [SerializeField] private GameObject messagePrefab;
    [SerializeField] private string sender;

    public void SubmitMessage()
    {
        if (inputField.text == "") return;
        var messageGo = Instantiate(messagePrefab, messageBox);
        messageGo.GetComponentInChildren<Text>().text = $"{sender}: {inputField.text}";
        inputField.text = "";
    }
}
