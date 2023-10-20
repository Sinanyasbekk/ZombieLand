using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningManager : MonoBehaviour
{
    //the instnce on the scene
    public static SpawningManager instance;
    //the team spawn
    GameObject[] redTeamSpawns;
    GameObject[] blueTeamSpawns;

    // Start is called before the first frame update
    void Awake()
    {
        //recreate the instance on awake- ie if scene reloads
        instance = this;
        redTeamSpawns = GameObject.FindGameObjectsWithTag("RedSpawn");
        blueTeamSpawns = GameObject.FindGameObjectsWithTag("BlueSpawn");
    }

    public Transform GetRandomRedSpawn()
    {
        //return a transform for one of the red spawns
        return redTeamSpawns[Random.Range(0, redTeamSpawns.Length)].transform;
    }

    public Transform GetRandomBlueSpawn()
    {
        //return a transform for one of the red spawns
        return blueTeamSpawns[Random.Range(0, redTeamSpawns.Length)].transform;
    }
    //this method gets given the team number to find a spawn for
    public Transform GetTeamSpawn(int teamNumber)
    {
        return teamNumber == 0 ? GetRandomBlueSpawn() : GetRandomRedSpawn();
    }


}
