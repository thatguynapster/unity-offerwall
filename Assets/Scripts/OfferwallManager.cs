using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfferwallManager : MonoBehaviour
{
    public string token;
    public string user_id;

    // Start is called before the first frame update
    void Start()
    {
        BitLabs.Init(token, user_id);
    }

    public void LaunchOffers()
    {
        BitLabs.LaunchOfferWall();
    }
}
