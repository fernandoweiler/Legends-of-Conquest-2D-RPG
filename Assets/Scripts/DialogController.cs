using TMPro;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText, nameText;
    [SerializeField] private GameObject dialogBox, nameBox;

    [SerializeField] private string[] dialogSentences;
    [SerializeField] private int currentSentence;

    // Start is called before the first frame update
    private void Start()
    {
        dialogText.text = dialogSentences[currentSentence];
    }

    // Update is called once per frame
    private void Update()
    {
    }
}