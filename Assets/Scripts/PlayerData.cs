using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    public static PlayerData Instance;

    public string playerName;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        //LoadPlayerName();
    }

    [System.Serializable] // Required by JsonUtility
    class SaveName
    {
        public string playerName;
        
    }


}
