using UnityEngine;

public class DialogHandler : MonoBehaviour
{
    public string[] sentences;
    private bool canActivate;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (canActivate && Input.GetButtonDown("Fire1"))
        {
            Debug.Log("AHOI AHOI");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canActivate = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            canActivate = false;
        }
    }
}