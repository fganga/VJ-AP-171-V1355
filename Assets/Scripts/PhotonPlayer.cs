using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonPlayer : MonoBehaviour
{
    private PhotonView photonView;
    private GameObject cameraGO;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("Starting player script");
        if (photonView.IsMine)
        {
        Debug.Log("Is mine");
        GetComponent<MovementInput>().enabled = true;
        
     


                

        }
        
    }
    private void Awake()

        {
    photonView = GetComponent<PhotonView>();
            
        }

    // Update is called once per frame
    void Update()
    {
       
    }
}
