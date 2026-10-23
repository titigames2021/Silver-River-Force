// GENERATED AUTOMATICALLY FROM 'Assets/_Scripts/Gamepad.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Gamepad : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Gamepad()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Gamepad"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""c5c01062-74da-48a7-bb6c-2a8188b82204"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""96eb9f35-dd60-41a7-a9ea-ad60b5c1d78c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""5cd78f8b-82e2-4750-b319-7f747384c571"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LRoll"",
                    ""type"": ""Button"",
                    ""id"": ""35eaaa66-0cd0-4ac0-bf7e-2e52e32cecc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RRoll"",
                    ""type"": ""Button"",
                    ""id"": ""103338b5-e0e4-4815-8700-cdfd0f37d519"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""920eb61f-bbfb-4f4e-9d0e-7a351c98f092"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""616e3846-a726-4103-9138-5a2a096af5c7"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d38598d5-92a8-4925-937d-a9fd39b71d61"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df6b3108-925a-4c3e-b838-e8063161882f"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f65c47e-1e55-4853-afad-4a706d71dfd3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a79f2ddd-6fd3-413b-97ba-329e406c9177"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_Boost = m_Gameplay.FindAction("Boost", throwIfNotFound: true);
        m_Gameplay_LRoll = m_Gameplay.FindAction("LRoll", throwIfNotFound: true);
        m_Gameplay_RRoll = m_Gameplay.FindAction("RRoll", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_Boost;
    private readonly InputAction m_Gameplay_LRoll;
    private readonly InputAction m_Gameplay_RRoll;
    private readonly InputAction m_Gameplay_Move;
    public struct GameplayActions
    {
        private @Gamepad m_Wrapper;
        public GameplayActions(@Gamepad wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @Boost => m_Wrapper.m_Gameplay_Boost;
        public InputAction @LRoll => m_Wrapper.m_Gameplay_LRoll;
        public InputAction @RRoll => m_Wrapper.m_Gameplay_RRoll;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                @Boost.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBoost;
                @LRoll.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLRoll;
                @LRoll.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLRoll;
                @LRoll.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLRoll;
                @RRoll.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRRoll;
                @RRoll.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRRoll;
                @RRoll.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRRoll;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @LRoll.started += instance.OnLRoll;
                @LRoll.performed += instance.OnLRoll;
                @LRoll.canceled += instance.OnLRoll;
                @RRoll.started += instance.OnRRoll;
                @RRoll.performed += instance.OnRRoll;
                @RRoll.canceled += instance.OnRRoll;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnLRoll(InputAction.CallbackContext context);
        void OnRRoll(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
