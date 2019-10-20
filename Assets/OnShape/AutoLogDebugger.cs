using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AutoLogDebugger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var url = @"https://oauth.onshape.com/oauth/authorize?response_type=code&client_id=4OMIXKUICROTVQSOOGSBGM2YLE5KVHI2ADZ3IHY=&grant_type=authorization_code&redirect_uri=http://localhost:1212/";

        Process.Start(url);
    }

}
