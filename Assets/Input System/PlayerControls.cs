// GENERATED AUTOMATICALLY FROM 'Assets/Input System/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f8734a6e-e93d-46b3-bb5d-e937121e4c71"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c975f79a-a973-468e-a4a8-d88c046b3030"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7083c601-80cc-4561-b5e7-da5db5d9f4dd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootLeft"",
                    ""type"": ""Button"",
                    ""id"": ""765bcec0-f9e3-430a-80f7-d544ec2a0ce0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootRight"",
                    ""type"": ""Button"",
                    ""id"": ""3d1e0cb1-47eb-4eb7-bb1d-2793b918317a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EquipLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e1b5644a-057d-4ecf-868d-4b8de4ec131d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EquipRight"",
                    ""type"": ""Button"",
                    ""id"": ""7270f22f-3a63-4b5f-8048-fae3bfcbed56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""b3f4ac42-8d11-4edf-931f-acee129f2bb5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b6ba10c9-9476-4e0c-abd1-1cfd9ef691e3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5b69b466-5bb7-4783-a253-e2ea45edcf8c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a74fe27-e3b8-4612-a827-7253eaa6bc36"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed912992-d07c-422d-a5c0-5b4d7efe33bf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4e943826-3ff2-4eca-a212-860e7c653be4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7786bec8-7065-4ada-988e-d718a876d707"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""feb46245-85fb-4dd1-a303-6c9e4bf05ac7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b062e658-68fe-4b72-a3a1-4e3c2c34233e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d1f2ca7-aca8-4d85-b075-b4c30fb8cb57"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Scarecrow"",
            ""id"": ""7cd00adf-d31b-4763-af7f-2462ad7ca98b"",
            ""actions"": [
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""b09afb73-8f5f-481f-ae20-9024327a6354"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6cd4e342-42cf-4f58-9f05-686099276084"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_CameraRotation = m_Player.FindAction("CameraRotation", throwIfNotFound: true);
        m_Player_ShootLeft = m_Player.FindAction("ShootLeft", throwIfNotFound: true);
        m_Player_ShootRight = m_Player.FindAction("ShootRight", throwIfNotFound: true);
        m_Player_EquipLeft = m_Player.FindAction("EquipLeft", throwIfNotFound: true);
        m_Player_EquipRight = m_Player.FindAction("EquipRight", throwIfNotFound: true);
        // Scarecrow
        m_Scarecrow = asset.FindActionMap("Scarecrow", throwIfNotFound: true);
        m_Scarecrow_Reset = m_Scarecrow.FindAction("Reset", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_CameraRotation;
    private readonly InputAction m_Player_ShootLeft;
    private readonly InputAction m_Player_ShootRight;
    private readonly InputAction m_Player_EquipLeft;
    private readonly InputAction m_Player_EquipRight;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @CameraRotation => m_Wrapper.m_Player_CameraRotation;
        public InputAction @ShootLeft => m_Wrapper.m_Player_ShootLeft;
        public InputAction @ShootRight => m_Wrapper.m_Player_ShootRight;
        public InputAction @EquipLeft => m_Wrapper.m_Player_EquipLeft;
        public InputAction @EquipRight => m_Wrapper.m_Player_EquipRight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @CameraRotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraRotation;
                @ShootLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLeft;
                @ShootLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLeft;
                @ShootLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootLeft;
                @ShootRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootRight;
                @ShootRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootRight;
                @ShootRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShootRight;
                @EquipLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipLeft;
                @EquipLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipLeft;
                @EquipLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipLeft;
                @EquipRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipRight;
                @EquipRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipRight;
                @EquipRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEquipRight;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @ShootLeft.started += instance.OnShootLeft;
                @ShootLeft.performed += instance.OnShootLeft;
                @ShootLeft.canceled += instance.OnShootLeft;
                @ShootRight.started += instance.OnShootRight;
                @ShootRight.performed += instance.OnShootRight;
                @ShootRight.canceled += instance.OnShootRight;
                @EquipLeft.started += instance.OnEquipLeft;
                @EquipLeft.performed += instance.OnEquipLeft;
                @EquipLeft.canceled += instance.OnEquipLeft;
                @EquipRight.started += instance.OnEquipRight;
                @EquipRight.performed += instance.OnEquipRight;
                @EquipRight.canceled += instance.OnEquipRight;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Scarecrow
    private readonly InputActionMap m_Scarecrow;
    private IScarecrowActions m_ScarecrowActionsCallbackInterface;
    private readonly InputAction m_Scarecrow_Reset;
    public struct ScarecrowActions
    {
        private @PlayerControls m_Wrapper;
        public ScarecrowActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Reset => m_Wrapper.m_Scarecrow_Reset;
        public InputActionMap Get() { return m_Wrapper.m_Scarecrow; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScarecrowActions set) { return set.Get(); }
        public void SetCallbacks(IScarecrowActions instance)
        {
            if (m_Wrapper.m_ScarecrowActionsCallbackInterface != null)
            {
                @Reset.started -= m_Wrapper.m_ScarecrowActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_ScarecrowActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_ScarecrowActionsCallbackInterface.OnReset;
            }
            m_Wrapper.m_ScarecrowActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
            }
        }
    }
    public ScarecrowActions @Scarecrow => new ScarecrowActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnShootLeft(InputAction.CallbackContext context);
        void OnShootRight(InputAction.CallbackContext context);
        void OnEquipLeft(InputAction.CallbackContext context);
        void OnEquipRight(InputAction.CallbackContext context);
    }
    public interface IScarecrowActions
    {
        void OnReset(InputAction.CallbackContext context);
    }
}
