using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Logger : MonoBehaviour
{
    private static Logger INSTANCE;

    [Header("Active View Ports")]
    [SerializeField] private bool _isViewInConsole = true;
    [SerializeField] private bool _isViewInUI = true;
    [SerializeField] private bool _isViewInFile = true;

    [Header("View Ports")]
    [SerializeField] private TMP_Text _uiViewPort;
    [SerializeField] private string _pathToFile = "_Log.txt";

    public static Logger Instance => INSTANCE;

    private string _headerLog = "--> ";
    private string _headerWarning = "!-> ";
    private string _headerError = "!!> ";

    private void Awake()
    {
        INSTANCE = this;
    }

    public void Log(string message)
    {
        if(_isViewInConsole)
            Debug.Log(_headerLog + message);

        if (_isViewInUI && _uiViewPort != null)
            _uiViewPort.text += _headerLog + message + "\r\n";
        else
            LogError("Logger.Log: UI View Port Is NULL!");

        if (_isViewInFile)
            WriteToFile(_headerLog + message);
    }

    public void LogWarning(string message)
    {
        if (_isViewInConsole)
            Debug.LogWarning(_headerWarning + message);

        if (_isViewInUI && _uiViewPort != null)
            _uiViewPort.text += _headerWarning + message + "\r\n";
        else
            LogError("Logger.LogWarning: UI View Port Is NULL!");

        if (_isViewInFile)
            WriteToFile(_headerWarning + message);
    }

    public void LogError(string message)
    {
        if (_isViewInConsole)
            Debug.LogError(_headerError + message);

        if (_isViewInUI && _uiViewPort != null)
            _uiViewPort.text += _headerError + message + "\r\n";
        else
            LogError("Logger.LogError: UI View Port Is NULL!");

        if (_isViewInFile)
            WriteToFile(_headerError + message);
    }

    private void WriteToFile(string message)
    {
        using (StreamWriter writer = new StreamWriter(_pathToFile, true))
        {
            writer.WriteLine(DateTime.Now.ToString() + ": " + message);
        }
    }
}
