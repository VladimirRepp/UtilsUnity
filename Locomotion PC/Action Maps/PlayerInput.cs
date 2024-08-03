//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.8.1
//     from Assets/Action Maps/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""65814170-b6aa-4c86-a979-4a2c8c7f2282"",
            ""actions"": [
                {
                    ""name"": ""Speedup"",
                    ""type"": ""Button"",
                    ""id"": ""27781e78-a09b-41f2-8a0a-bfc4d664d33b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f0d4447e-e8b0-4f18-bf0f-dbf1dd378470"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7fb23b4f-179b-47cf-bbe6-f5c312a1d251"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fly"",
                    ""type"": ""Value"",
                    ""id"": ""530c8a9f-6e6d-4a93-9fee-f7923b02dece"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c02074e0-6d53-4fb2-a1c0-20214a547ec2"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Speedup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8306a20b-0ddb-47d7-9764-d142aa8adf5c"",
                    ""path"": ""<XRController>{LeftHand}/joystickClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";XR Controller"",
                    ""action"": ""Speedup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0573f63-80dc-426a-bdae-844097e8ca8f"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Speedup"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""id"": ""0f2c38de-4de7-4cea-b425-d060128964e9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""98bd7ce8-7956-4263-b5bb-bc2f3039c7af"",
                    ""path"": ""<Mouse>/delta/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6253b4b1-10f7-4015-8bae-e4ddae1499e0"",
                    ""path"": ""<Mouse>/delta/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e750c0ac-07c1-4752-89fb-eac6a947bd5d"",
                    ""path"": ""<Mouse>/delta/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e5422b7a-4b31-4e9f-9713-199fb9bb873d"",
                    ""path"": ""<Mouse>/delta/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""e3e02b66-c4fb-443d-b2a9-883cd1f58de4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5f1075c1-c4f0-4e55-a064-094344a5822b"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a863a0e5-aa42-42d2-8120-79828ce259d8"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a5c5f6c7-1416-4c6c-bd84-63ff484c2f3d"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""51c1a16e-baea-4469-8429-fd07eabd5a8d"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2d2888fe-aee0-41ff-ae4f-dc74333a9c41"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""07a51b90-c17f-480e-995f-4fa3be62612f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""551afbfd-111a-45f5-a07e-15948bc52024"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d867e2a0-21de-4a6a-a332-9f0537a647a0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f92d6183-7ce1-4e21-80dc-f1a293c45678"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""636d5f96-c7fb-4296-96c4-207fd396b3f5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e36f701e-be91-40d9-b87e-4e3a1fc821ae"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e40544f0-e8a0-41f8-bbe3-c2771d7f18f8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ab406b35-21c4-4db5-98b2-3d558d163716"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b58c1e52-3ae9-422e-932d-c41661b9c8eb"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""QE"",
                    ""id"": ""f5406b85-4780-46e2-9486-f19988c228db"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""d3086411-2445-4b59-a406-4ce75dd848e1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""ecaa9b6a-3605-47a0-b27e-d3ad0425ea56"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard And Mouse"",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b146a696-a203-445e-8ad1-278fbd5c9fb0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ea3328ee-cd89-46e7-9800-fbbc448fc12b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""444beeeb-0a4d-4eb8-864a-1557a66935f5"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""DEBUG_PlayerActionMap"",
            ""id"": ""5f09d4c2-b138-4154-85c2-d8895d6fae3f"",
            ""actions"": [
                {
                    ""name"": ""Switch Level"",
                    ""type"": ""Button"",
                    ""id"": ""905c22db-2a62-4661-b8c4-601cbcdac0d5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e9c4dc3-c754-4131-b2a8-045514eb79ea"",
                    ""path"": ""<XRController>{LeftHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch Level"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""XR Controller"",
            ""bindingGroup"": ""XR Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard And Mouse"",
            ""bindingGroup"": ""Keyboard And Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerActionMap
        m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
        m_PlayerActionMap_Speedup = m_PlayerActionMap.FindAction("Speedup", throwIfNotFound: true);
        m_PlayerActionMap_Look = m_PlayerActionMap.FindAction("Look", throwIfNotFound: true);
        m_PlayerActionMap_Move = m_PlayerActionMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerActionMap_Fly = m_PlayerActionMap.FindAction("Fly", throwIfNotFound: true);
        // DEBUG_PlayerActionMap
        m_DEBUG_PlayerActionMap = asset.FindActionMap("DEBUG_PlayerActionMap", throwIfNotFound: true);
        m_DEBUG_PlayerActionMap_SwitchLevel = m_DEBUG_PlayerActionMap.FindAction("Switch Level", throwIfNotFound: true);
    }

    ~@PlayerInput()
    {
        Debug.Assert(!m_PlayerActionMap.enabled, "This will cause a leak and performance issues, PlayerInput.PlayerActionMap.Disable() has not been called.");
        Debug.Assert(!m_DEBUG_PlayerActionMap.enabled, "This will cause a leak and performance issues, PlayerInput.DEBUG_PlayerActionMap.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerActionMap
    private readonly InputActionMap m_PlayerActionMap;
    private List<IPlayerActionMapActions> m_PlayerActionMapActionsCallbackInterfaces = new List<IPlayerActionMapActions>();
    private readonly InputAction m_PlayerActionMap_Speedup;
    private readonly InputAction m_PlayerActionMap_Look;
    private readonly InputAction m_PlayerActionMap_Move;
    private readonly InputAction m_PlayerActionMap_Fly;
    public struct PlayerActionMapActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActionMapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Speedup => m_Wrapper.m_PlayerActionMap_Speedup;
        public InputAction @Look => m_Wrapper.m_PlayerActionMap_Look;
        public InputAction @Move => m_Wrapper.m_PlayerActionMap_Move;
        public InputAction @Fly => m_Wrapper.m_PlayerActionMap_Fly;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Add(instance);
            @Speedup.started += instance.OnSpeedup;
            @Speedup.performed += instance.OnSpeedup;
            @Speedup.canceled += instance.OnSpeedup;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Fly.started += instance.OnFly;
            @Fly.performed += instance.OnFly;
            @Fly.canceled += instance.OnFly;
        }

        private void UnregisterCallbacks(IPlayerActionMapActions instance)
        {
            @Speedup.started -= instance.OnSpeedup;
            @Speedup.performed -= instance.OnSpeedup;
            @Speedup.canceled -= instance.OnSpeedup;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Fly.started -= instance.OnFly;
            @Fly.performed -= instance.OnFly;
            @Fly.canceled -= instance.OnFly;
        }

        public void RemoveCallbacks(IPlayerActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);

    // DEBUG_PlayerActionMap
    private readonly InputActionMap m_DEBUG_PlayerActionMap;
    private List<IDEBUG_PlayerActionMapActions> m_DEBUG_PlayerActionMapActionsCallbackInterfaces = new List<IDEBUG_PlayerActionMapActions>();
    private readonly InputAction m_DEBUG_PlayerActionMap_SwitchLevel;
    public struct DEBUG_PlayerActionMapActions
    {
        private @PlayerInput m_Wrapper;
        public DEBUG_PlayerActionMapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SwitchLevel => m_Wrapper.m_DEBUG_PlayerActionMap_SwitchLevel;
        public InputActionMap Get() { return m_Wrapper.m_DEBUG_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DEBUG_PlayerActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IDEBUG_PlayerActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_DEBUG_PlayerActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DEBUG_PlayerActionMapActionsCallbackInterfaces.Add(instance);
            @SwitchLevel.started += instance.OnSwitchLevel;
            @SwitchLevel.performed += instance.OnSwitchLevel;
            @SwitchLevel.canceled += instance.OnSwitchLevel;
        }

        private void UnregisterCallbacks(IDEBUG_PlayerActionMapActions instance)
        {
            @SwitchLevel.started -= instance.OnSwitchLevel;
            @SwitchLevel.performed -= instance.OnSwitchLevel;
            @SwitchLevel.canceled -= instance.OnSwitchLevel;
        }

        public void RemoveCallbacks(IDEBUG_PlayerActionMapActions instance)
        {
            if (m_Wrapper.m_DEBUG_PlayerActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDEBUG_PlayerActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_DEBUG_PlayerActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DEBUG_PlayerActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DEBUG_PlayerActionMapActions @DEBUG_PlayerActionMap => new DEBUG_PlayerActionMapActions(this);
    private int m_XRControllerSchemeIndex = -1;
    public InputControlScheme XRControllerScheme
    {
        get
        {
            if (m_XRControllerSchemeIndex == -1) m_XRControllerSchemeIndex = asset.FindControlSchemeIndex("XR Controller");
            return asset.controlSchemes[m_XRControllerSchemeIndex];
        }
    }
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard And Mouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActionMapActions
    {
        void OnSpeedup(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnFly(InputAction.CallbackContext context);
    }
    public interface IDEBUG_PlayerActionMapActions
    {
        void OnSwitchLevel(InputAction.CallbackContext context);
    }
}