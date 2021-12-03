using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextGame : MonoBehaviour
{
    void AudioLoader()
    {
        GameObject gameObject = GameObject.Find("Canvas");
        AudioSource audio = gameObject.GetComponent<AudioSource>();
        audio.Play();
    }

    int SceneChecker()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainMenu")
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
        
    
    void TextLoader()
    {
        Text textUI;
        textUI = GetComponent<Text>();

        if (SceneChecker() == 0)
        {
           textUI.text = "Znajdujesz sie w miescie Pani Bólu. \n" +
                        "Nie wiesz jak siê tu znalazles. \n" +
                         "Nacisnij klawisz ENTER, aby kontynowac swoja przygode \n";
        }
        else
        {
            textUI.text = "Opis lokalizacji";
        }
    }

    void SceneLoader()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Levels");
        }

    }


    void Start()
    {
        TextLoader();
        AudioLoader();
    }


    void Update()
    {
        SceneLoader();
        
    }
}
