using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonService : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.GameVersion ="0.1";
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Iniciando conexión.");
    }
    public override void OnConnectedToMaster(){
        //Sincroniza la escena
        PhotonNetwork.AutomaticallySyncScene = true;
        Debug.Log("Conectado a Photon");
    }
    public override void OnDisconnected(DisconnectCause dc){
        Debug.Log("Desconectado ----");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
