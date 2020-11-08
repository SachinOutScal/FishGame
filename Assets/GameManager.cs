using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log(" GameManager Instance is NULL");
            }
            return _instance;
        }
    }
    public void Awake()
    {
        _instance = this;
    }
    #endregion

    
    [SerializeField]UIController uiController; 

    public void OnFishCatch()
    {
        if (uiController.score <= 300)
        {
            uiController.InGameUpdate();
            SoundManager.Instance.Play(SoundList.ItemCollect);
        }
       
    }


}
