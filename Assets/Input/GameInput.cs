//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input/GameInput.inputactions
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

public partial class @GameInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""05d76475-92db-4016-a9bf-d837b14df788"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a412a395-d31b-46bb-ac4b-5b9196701774"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""227ca5e7-4244-468f-99b1-c920d5e4002c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""f8ab1842-6149-4d2e-a88e-81f682d0acee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e89fa10b-1c1f-4668-a0f1-470b4c16a4ac"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""912d32c7-a8b9-446c-9296-c4b6c3cb7b09"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8de208de-8637-40c9-8c26-1fd7361f2f54"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap(duration=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOnFoot
        m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
        m_PlayerOnFoot_HorizontalMove = m_PlayerOnFoot.FindAction("HorizontalMove", throwIfNotFound: true);
        m_PlayerOnFoot_Jump = m_PlayerOnFoot.FindAction("Jump", throwIfNotFound: true);
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

    // PlayerOnFoot
    private readonly InputActionMap m_PlayerOnFoot;
    private List<IPlayerOnFootActions> m_PlayerOnFootActionsCallbackInterfaces = new List<IPlayerOnFootActions>();
    private readonly InputAction m_PlayerOnFoot_HorizontalMove;
    private readonly InputAction m_PlayerOnFoot_Jump;
    public struct PlayerOnFootActions
    {
        private @GameInput m_Wrapper;
        public PlayerOnFootActions(@GameInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMove => m_Wrapper.m_PlayerOnFoot_HorizontalMove;
        public InputAction @Jump => m_Wrapper.m_PlayerOnFoot_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerOnFootActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerOnFootActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerOnFootActionsCallbackInterfaces.Add(instance);
            @HorizontalMove.started += instance.OnHorizontalMove;
            @HorizontalMove.performed += instance.OnHorizontalMove;
            @HorizontalMove.canceled += instance.OnHorizontalMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IPlayerOnFootActions instance)
        {
            @HorizontalMove.started -= instance.OnHorizontalMove;
            @HorizontalMove.performed -= instance.OnHorizontalMove;
            @HorizontalMove.canceled -= instance.OnHorizontalMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IPlayerOnFootActions instance)
        {
            if (m_Wrapper.m_PlayerOnFootActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerOnFootActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerOnFootActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerOnFootActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);
    public interface IPlayerOnFootActions
    {
        void OnHorizontalMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
