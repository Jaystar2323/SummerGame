// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

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
            ""name"": ""GameControls"",
            ""id"": ""1635e79e-eb31-4130-b729-5186adad96f6"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c0724816-f3ed-45d7-b9da-b66eb6b0f02f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8bd75b1b-7548-48d3-83a8-f6cc99dea0e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability1"",
                    ""type"": ""Button"",
                    ""id"": ""c094f658-f801-44e5-ac57-e63ed9dbd071"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability2"",
                    ""type"": ""Button"",
                    ""id"": ""443f94cc-8168-41b5-bd37-e13ee9d48299"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9ee9059b-6f00-4396-b285-173f94541aa9"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""927b5191-84a5-49c3-b39f-2ef73edec77f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bff1619e-7b2e-4d63-b59c-018f564d84e7"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Ability1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d29ad90-026b-46e3-b47e-634494bab18b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ability1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4df2a1b2-d201-4669-80a5-6c8118d4e650"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""Ability2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3b1a81c-4de9-470e-b9be-1f807a12c08c"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ability2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79a39993-9b35-488d-bd9f-d717088d428b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4894e608-5cb8-47ec-8bcf-c74307fa80bd"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d5e1330d-0094-4f2a-8eb0-8127ca4e4713"",
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
                    ""id"": ""bae1bb9d-34f9-4fa1-be98-f6bb255719f2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3e71bb76-eefb-4274-a3c5-b2a70bd6e86c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""86f26fdd-2bde-42d3-9bd1-ea2536a9cc08"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eb040a03-0fd3-4d18-991f-cc739164e42b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player"",
            ""bindingGroup"": ""Player"",
            ""devices"": []
        }
    ]
}");
        // GameControls
        m_GameControls = asset.FindActionMap("GameControls", throwIfNotFound: true);
        m_GameControls_Rotate = m_GameControls.FindAction("Rotate", throwIfNotFound: true);
        m_GameControls_Shoot = m_GameControls.FindAction("Shoot", throwIfNotFound: true);
        m_GameControls_Ability1 = m_GameControls.FindAction("Ability1", throwIfNotFound: true);
        m_GameControls_Ability2 = m_GameControls.FindAction("Ability2", throwIfNotFound: true);
        m_GameControls_Move = m_GameControls.FindAction("Move", throwIfNotFound: true);
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

    // GameControls
    private readonly InputActionMap m_GameControls;
    private IGameControlsActions m_GameControlsActionsCallbackInterface;
    private readonly InputAction m_GameControls_Rotate;
    private readonly InputAction m_GameControls_Shoot;
    private readonly InputAction m_GameControls_Ability1;
    private readonly InputAction m_GameControls_Ability2;
    private readonly InputAction m_GameControls_Move;
    public struct GameControlsActions
    {
        private @PlayerControls m_Wrapper;
        public GameControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_GameControls_Rotate;
        public InputAction @Shoot => m_Wrapper.m_GameControls_Shoot;
        public InputAction @Ability1 => m_Wrapper.m_GameControls_Ability1;
        public InputAction @Ability2 => m_Wrapper.m_GameControls_Ability2;
        public InputAction @Move => m_Wrapper.m_GameControls_Move;
        public InputActionMap Get() { return m_Wrapper.m_GameControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameControlsActions instance)
        {
            if (m_Wrapper.m_GameControlsActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnRotate;
                @Shoot.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnShoot;
                @Ability1.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAbility1;
                @Ability1.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAbility1;
                @Ability1.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAbility1;
                @Ability2.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAbility2;
                @Ability2.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAbility2;
                @Ability2.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnAbility2;
                @Move.started -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameControlsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Ability1.started += instance.OnAbility1;
                @Ability1.performed += instance.OnAbility1;
                @Ability1.canceled += instance.OnAbility1;
                @Ability2.started += instance.OnAbility2;
                @Ability2.performed += instance.OnAbility2;
                @Ability2.canceled += instance.OnAbility2;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameControlsActions @GameControls => new GameControlsActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IGameControlsActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAbility1(InputAction.CallbackContext context);
        void OnAbility2(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
