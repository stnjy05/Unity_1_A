using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exgamemanager : MonoBehaviour
{
    // Start is called before the first frame update

    public ExGameData gameData;
    void Start()
    {
        Debug.Log("Game Name : " + gameData.gameName);
        Debug.Log("Game Score :" + gameData.gameScore);
        Debug.Log("Is Game Active :" + gameData.isGameActive);
        
    }

}
