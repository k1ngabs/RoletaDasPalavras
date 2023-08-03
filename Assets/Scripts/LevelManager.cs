using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] Levels;
    public GameObject TelaParabens;
    int currentLevel;
    int levelCount;

    public void correctAnswer(){
        if (currentLevel + 1 != Levels.Length){
            TelaParabens.SetActive(false);
            Levels[currentLevel].SetActive(false);
            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
    }
    

    public void questionBefore(){
        TelaParabens.SetActive(false);
        if (currentLevel != 0){
            Levels[currentLevel].SetActive(false);
            currentLevel--;
            Levels[currentLevel].SetActive(true);
        }
    }

}


    
