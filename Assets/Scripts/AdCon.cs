using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Advertisements;
public class AdCon : MonoBehaviour
{
    bool adShown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Advertisement.IsReady() && adShown == false) {
            Debug.Log("Ad is ready");
            Advertisement.Show();
            adShown = true;
        }
    }
}
