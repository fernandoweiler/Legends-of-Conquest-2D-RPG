using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Image imageToFade;

    public static MenuManager Instance;

    private void Start()
    {
        Instance = this;
    }

    public void FadeImage()
    {
        imageToFade.GetComponent<Animator>().SetTrigger("Start Fading");
    }
}