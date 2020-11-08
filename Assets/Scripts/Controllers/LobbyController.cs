using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    public Button newGameButton;
   
    private void Start()
    {
        newGameButton.onClick.AddListener(LoadNewGame);

    }

    private void LevelSelection()
    {
        
        SoundManager.Instance.Play(SoundList.ButtonClickPlay);
       
        newGameButton.transform.parent.gameObject.SetActive(false);
       
    }

    private void LoadNewGame()
    {
        SoundManager.Instance.Play(SoundList.ButtonClickPlay);
       
        SceneManager.LoadScene(1); 
    }





}
