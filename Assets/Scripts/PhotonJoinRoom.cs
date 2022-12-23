using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonJoinRoom : MonoBehaviourPunCallbacks
{
    public int number;
    public void JoinRandomRoom(){
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Joined to random room");
        // Debug.Log(PhotonNetwork.CurrentRoom.Name);
    }
    public override void OnJoinRandomFailed(short returnCode,string message){
        Debug.Log("Error to join ramdom. Trying again");
        createRoom();

    }
     public void createRoom(){
        number = Random.Range(1,100);
        Debug.Log("Room number : " + number);
        Debug.Log("-- Start Creating Room ---");
        PhotonNetwork.JoinOrCreateRoom("Room " + number,new RoomOptions() {MaxPlayers= 2},TypedLobby.Default);
        Debug.Log("Room Created");
        PhotonNetwork.LoadLevel("Scenes/PlatformActionScene");
       
    }
     public override void OnCreateRoomFailed(short returnCode,string message){
        Debug.Log("Trying to create new room");
        createRoom();

    }
}
