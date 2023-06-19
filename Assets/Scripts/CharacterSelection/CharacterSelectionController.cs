using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CharacterSelectionController : MonoBehaviour
{
    public List<Sprite> characterImage;

    [SerializeField]
    Image _imageUI;
    [SerializeField]
    TextMeshProUGUI _textName;
    [SerializeField]
    TMP_InputField _nameText;

     int _selectedCharacter;

    private void Awake()
    {
        _imageUI.sprite = characterImage[0];
        _selectedCharacter = 0;
        
    }
    public void StartGame()
    {
        SaveSelection();
        SceneManager.LoadScene("GamePlay");

    }
    private void Update()
    {
        if(_selectedCharacter == 0)
        {
            _textName.text = "MALE";
        }else if(_selectedCharacter == 1)
        {
            _textName.text = "FEMALE";
        }
    }
    public void NextGender(bool value)
    {
        if (value)
        {
            _selectedCharacter =0;

            _imageUI.sprite = characterImage[0];


        }
        else
        {
            _selectedCharacter = 1;

            _imageUI.sprite = characterImage[1];
        }

    }

    public void SaveSelection()
    {
        PlayerPrefs.SetInt("GenderSelected", _selectedCharacter);
        PlayerPrefs.Save();
  
    }


  
}
