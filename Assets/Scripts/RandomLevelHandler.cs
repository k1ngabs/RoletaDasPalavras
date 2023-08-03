using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomLevelHandler : MonoBehaviour
{
    public GameObject[] RLevels;
    public GameObject TelaParabens;
    public GameObject TelaEndGame;
    int levelCount;
    int currentLevel;
    [SerializeField] int maxLevelCount;
    public void randomizeNextLevelNoRepeat(){
        int nextLevel = Random.Range(0, RLevels.Length);
            if (RLevels[nextLevel].tag != "Played"){
                RLevels[nextLevel].SetActive(true);
                RLevels[nextLevel].tag = "Played";
                currentLevel = nextLevel;
                levelCount++;
            }else if (RLevels[nextLevel].tag == "Played" ){
                randomizeNextLevelNoRepeat();
            }
    }

    public void correctAnswer(){
        if ( levelCount < RLevels.Length && levelCount < maxLevelCount){
            TelaParabens.SetActive(false);
            RLevels[currentLevel].SetActive(false);
            randomizeNextLevelNoRepeat();
        }else if(levelCount == maxLevelCount){
            TelaParabens.SetActive(false);
            RLevels[currentLevel].SetActive(false);
            TelaEndGame.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        randomizeNextLevelNoRepeat();
    }
}
