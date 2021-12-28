using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    [SerializeField] string transitionName;

    // Start is called before the first frame update
    void Start()
    {
        if (transitionName != null && transitionName == Player.playerInstance.transitionName)
        {
            Player.playerInstance.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
