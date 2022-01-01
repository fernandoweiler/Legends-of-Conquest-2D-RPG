using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;
    [SerializeField] private string transitionName;
    [SerializeField] private AreaEnter areaEnter;

    // Start is called before the first frame update
    private void Start()
    {
        areaEnter.transitionName = transitionName;
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.Instance.transitionName = transitionName;

            MenuManager.Instance.FadeImage();

            StartCoroutine(LoadSceneCoroutine());
        }
    }

    private IEnumerator LoadSceneCoroutine()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(sceneToLoad);
    }
}