using TMPro;
using UnityEngine;

public class DialogController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI dialogText, nameText;
    [SerializeField] private GameObject dialogBox, nameBox;

    [SerializeField] private string[] dialogSentences;
    [SerializeField] private int currentSentence;

    public static DialogController Instance;

    // Start is called before the first frame update
    private void Start()
    {
        Instance = this;

        dialogText.text = dialogSentences[currentSentence];
    }

    // Update is called once per frame
    private void Update()
    {
        if (dialogBox.activeInHierarchy)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                currentSentence++;

                if (currentSentence >= dialogSentences.Length)
                {
                    dialogBox.SetActive(false);
                }
                else
                {
                    dialogText.text = dialogSentences[currentSentence];
                }
            }
        }
    }
}