using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class BController : MonoBehaviour
{
    bool adShown = false;
    public void ButtonClick(string sceneName) {
        if (adShown == true) {
            Application.LoadLevel(sceneName);
        } else if (Advertisement.IsReady() && adShown == false) {
            Debug.Log("Ad is ready");
            Advertisement.Show();
            Debug.Log("Ad shown");
            adShown = true;
        }
    }
    //Under Main Menu
    public void playButton(string sceneName) {
        Application.LoadLevel(sceneName);
    }
    
    public void settingsButton(string sceneName){
        Application.LoadLevel(sceneName);
    }
    //Under Settigns Menu
    public void returnButton(string sceneName){
        Application.LoadLevel(sceneName);
    }
    public void exitButton(){
        //Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void returnFromSceneButton(string sceneName){
        Application.LoadLevel(sceneName);
    }
}
