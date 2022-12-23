using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PhotonGame : MonoBehaviourPunCallbacks
{
    Player[] players;
    public int playerNumber;
    private GameObject playerGO,cameraGO;
    private PhotonView photonView;
    public Text txtUser,txtRoom;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
       
       
        
    }


    // Update is called once per frame
    void Update()
    {
       
        
    }
    public override void OnPlayerEnteredRoom(Player newPlayer){
        players = PhotonNetwork.PlayerList;
        playerNumber = players.Length;

        Debug.Log("Player number " + playerNumber + " joined to room.Entered.");
        PhotonNetwork.NickName = playerNumber.ToString();
        Debug.Log("Nickname :" + PhotonNetwork.NickName);
    }
    public override void OnJoinedRoom(){
        players = PhotonNetwork.PlayerList;
        playerNumber = players.Length;
         Debug.Log("Player number " + playerNumber + " joined to room.OnJoined.");
        PhotonNetwork.NickName = playerNumber.ToString();
        txtUser.text = "Usuario : "+PhotonNetwork.NickName;
        txtRoom.text = "Sala : " + PhotonNetwork.CurrentRoom.Name;


        playerGO = PhotonNetwork.Instantiate("Jammo_Player",transform.position,Quaternion.identity,0);
        playerGO.name ="Jammo"+playerNumber;
        Debug.Log("PlayerGO Name : " + playerGO.name);
       
      

      
       
    }
}
