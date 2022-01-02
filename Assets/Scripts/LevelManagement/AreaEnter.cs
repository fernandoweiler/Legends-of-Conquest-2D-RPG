using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    public string transitionName;

    // Start is called before the first frame update
    private void Start()
    {
        if (transitionName != null && transitionName == Player.Instance.transitionName)
        {
            Player.Instance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}