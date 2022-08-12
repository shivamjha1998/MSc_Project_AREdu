using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide : MonoBehaviour
{
    public GameObject popup;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (popup.activeInHierarchy == true)
            popup.SetActive(false);
        else
            popup.SetActive(true);
    }
}
