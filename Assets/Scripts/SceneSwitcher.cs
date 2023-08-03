using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{

    public void switchStartMenu(){
        SceneManager.LoadScene("StartMenu");
    }
    public void switchAlphabet(){
        SceneManager.LoadScene("Alphabet");
    }
    public void switchAlphabetRandom(){
        SceneManager.LoadScene("AlphabetRandom");
    }
    public void switchVogals(){
        SceneManager.LoadScene("Vogals");
    }
    public void switchVogalsRandom(){
        SceneManager.LoadScene("VogalsRandom");
    }
    public void switchConsoants(){
        SceneManager.LoadScene("Consoants");
    }
    public void switchConsoantsRandom(){
        SceneManager.LoadScene("Consoants");
    }
    public void quitGame(){
        Application.Quit();
    }
}
