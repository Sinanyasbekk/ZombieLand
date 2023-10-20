using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;

public class NetworkingTeam : MonoBehaviourPunCallbacks
{

    //clicked by a button with dynamic variable for what team to join
    public void JoinTeam(int team)
    {
        //do we already have a team?
        if (PhotonNetwork.LocalPlayer.CustomProperties.ContainsKey("Team"))
        {
            //we already have a team- so switch teams
            PhotonNetwork.LocalPlayer.CustomProperties["Team"] = team;
        }
        else
        {
            //we dont have a team yet- create the custom property and set it
            //0 for blue, 1 for red
            //set the player properties of this client to the team they clicked
            ExitGames.Client.Photon.Hashtable playerProps = new ExitGames.Client.Photon.Hashtable
        {
            { "Team", team }
        };
            //set the property of Team to the value the user wants
            PhotonNetwork.SetPlayerCustomProperties(playerProps);
        }

        //join the random room and launch game- the GameManager will spawn the correct model in based on the property
        PhotonNetwork.JoinRandomRoom();
    }



   


}