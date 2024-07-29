using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Utils
{
    public class FPSCounter : MonoBehaviour
    {
        [Header("Settings")]
        [SerializeField] [Tooltip ("How often should the number update")] private float _updateInterval = 0.5f;

        [Header("UI Settings")]
        [SerializeField] private bool _isUI_PortView = false;
        [SerializeField] private TMP_Text _wievPort;

        [Header("GUI Settings")]
        [SerializeField] private bool _isGUI_PortView = false;
        [SerializeField] [Tooltip("Position relative to the upper left angle")] private Vector2 _positin = new Vector2(5, 5);
        [SerializeField] private GUIStyle _gUIStyle = GUIStyle.none;

        float accum = 0.0f;
        int frames = 0;
        float timeleft;
        float fps;

        void Start()
        {
            timeleft = _updateInterval;

            _gUIStyle.fontStyle = FontStyle.Bold;
            _gUIStyle.normal.textColor = Color.white;
            _gUIStyle.fontSize = 80;
        }

        void Update()
        {
            timeleft -= Time.deltaTime;
            accum += Time.timeScale / Time.deltaTime;
            ++frames;

            if (timeleft <= 0.0)
            {
                fps = (accum / frames);
                timeleft = _updateInterval;
                accum = 0.0f;
                frames = 0;
            }

            if(_isUI_PortView)
                _wievPort.text = fps.ToString("F2") + "FPS";
        }

        void OnGUI()
        {
            try
            {
                if (_isGUI_PortView)
                    GUI.Label(new Rect(5, 5, 100, 25), fps.ToString("F2") + "FPS", _gUIStyle);
            }
            catch { }           
        }
    }
}
