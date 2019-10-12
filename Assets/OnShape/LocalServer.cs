using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using UnityEditor;
using UnityEngine;


public class LocalServer : MonoBehaviour
{

    private TcpListener server;

    public OnShapeMain Main;

    // Start is called before the first frame update
    void Start()
    {
        // TcpListener server = new TcpListener(port);
        server = new TcpListener(IPAddress.Any, OnshapeOAuth.SERVER_PORT);

        // Start listening for client requests.
        server.Start();

        server.BeginAcceptTcpClient(OnData, null);
    }

    private void OnData(IAsyncResult ar)
    {
        var client = server.EndAcceptTcpClient(ar);

        var stream = client.GetStream();


        var sr = new StreamReader(stream);
        string inputString;

        var inputLines = new List<string>();


        string code = null;

        do
        {
            inputString = sr.ReadLine();
            inputLines.Add(inputString);

            if (inputString != null && inputString.Contains("code="))
            {
                code=inputString.Split(new string[] { "ode=" }, StringSplitOptions.None)[1].Split(new string[] { " ", "&" }, StringSplitOptions.None)[0];
            }

        } while (!String.IsNullOrEmpty(inputString));

        var content = "<!DOCTYPE html><html><head><meta charset=\"UTF-8\"><title>Hey!</title></head><body onload='history.go(-1);'></body></html>";

        var sw = new StreamWriter(stream);

        sw.Write("HTTP/1.1 200 OK\r\n");
        sw.Write("Content-Type: text/html; charset=UTF-8\r\n");
        sw.Write("Content-Length: " + content.Length + "\r\n");
        sw.Write("\r\n");
        sw.Write(content);

        sw.Flush();


        client.Close();


        if (!string.IsNullOrEmpty(code))
        {
            OnshapeOAuth.Instance.AuthCode = code;
            _flagAfterConnect = true;
        }
        else
        {

            server.BeginAcceptTcpClient(OnData, null);
        }
    }

    private bool _flagAfterConnect = false;


    void Update()
    {
        if (_flagAfterConnect)
        {
            _flagAfterConnect = false;
            Main.AfterConnect();

        }
    }


           

}
