using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigManager : MonoBehaviour
{
    [SerializeField] Slider generalVolume;

    public void changeGeneralVolume(){
        AudioListener.volume = generalVolume.value;
        saveSettings();
    }

    public void loadSettings(){
        generalVolume.value = PlayerPrefs.GetFloat("generalVolume");
    }
    
    public void saveSettings(){
        PlayerPrefs.SetFloat("generalVolume", generalVolume.value);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("generalVolume")){
            PlayerPrefs.SetFloat("generalVolume", 1);
            loadSettings();
        } else {
            loadSettings();
        }
    }


}
