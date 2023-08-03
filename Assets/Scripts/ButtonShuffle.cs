using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonShuffle : MonoBehaviour
{

    public GameObject[] buttons;

    public void Shuffle()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int rnd = Random.Range(0, buttons.Length);
            Vector3 temp = buttons[rnd].transform.position;
            buttons[rnd].transform.position = buttons[i].transform.position;
            buttons[i].transform.position = temp;
        }
    }
    
    // Start is called before the first frame update
    private void Awake() {
        Shuffle();
    }

}
