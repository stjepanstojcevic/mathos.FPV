using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] Characters;
    public int selectedCharacter = 0;

    private void Start() {
        Characters[selectedCharacter].SetActive(false);
        selectedCharacter=(selectedCharacter+1) % Characters.Length;
        Characters[selectedCharacter].SetActive(true);
    }
    
    public void NextCar(){
        Characters[selectedCharacter].SetActive(false);
        selectedCharacter=(selectedCharacter+1) % Characters.Length;
        Characters[selectedCharacter].SetActive(true);
    }

    public void PeviousCar()
    {
        Characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if(selectedCharacter < 0)
        {
            selectedCharacter+= Characters.Length;
        }
        Characters[selectedCharacter].SetActive(true);
    }
    
    public void StartCar(){
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }
}
