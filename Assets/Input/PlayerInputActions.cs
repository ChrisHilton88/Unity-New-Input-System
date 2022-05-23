// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Dog"",
            ""id"": ""4423a920-4630-4fb9-a337-f034a20df407"",
            ""actions"": [
                {
                    ""name"": ""Bark"",
                    ""type"": ""Button"",
                    ""id"": ""c7efa544-76ad-4269-83a2-33b54cc6c615"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""c4b9b72a-a380-4c35-bfe2-386eb04e596a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Die"",
                    ""type"": ""Button"",
                    ""id"": ""c1deea02-4288-4903-828b-eecf79a51028"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""07741f4e-dea0-441c-94d1-2c7bac3f8a58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5887f078-a11a-4ea1-89a6-53c1dad9bff1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fdeae684-7666-44b3-9727-3894d37049af"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fd60bb67-03a0-4b63-ab99-bbfe785d4bdc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""babe873e-4fea-474b-a86d-f96e6a8e906f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""74785f19-05da-4a9a-83ec-22ff0227a140"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e04672f5-6e76-48c3-8a2a-d48b81b33bc4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""0cbd41b7-bb30-47b3-908a-b5bda7ebd078"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""237621ca-58ad-4267-8f9e-600dfcff8c16"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""15e28161-d7ac-4b5f-a371-1fed7c0320d7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Die"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42cbdcc4-3871-4340-a83e-2ca317b776b7"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Dog
        m_Dog = asset.FindActionMap("Dog", throwIfNotFound: true);
        m_Dog_Bark = m_Dog.FindAction("Bark", throwIfNotFound: true);
        m_Dog_Walk = m_Dog.FindAction("Walk", throwIfNotFound: true);
        m_Dog_Die = m_Dog.FindAction("Die", throwIfNotFound: true);
        m_Dog_Run = m_Dog.FindAction("Run", throwIfNotFound: true);
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

    // Dog
    private readonly InputActionMap m_Dog;
    private IDogActions m_DogActionsCallbackInterface;
    private readonly InputAction m_Dog_Bark;
    private readonly InputAction m_Dog_Walk;
    private readonly InputAction m_Dog_Die;
    private readonly InputAction m_Dog_Run;
    public struct DogActions
    {
        private @PlayerInputActions m_Wrapper;
        public DogActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bark => m_Wrapper.m_Dog_Bark;
        public InputAction @Walk => m_Wrapper.m_Dog_Walk;
        public InputAction @Die => m_Wrapper.m_Dog_Die;
        public InputAction @Run => m_Wrapper.m_Dog_Run;
        public InputActionMap Get() { return m_Wrapper.m_Dog; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DogActions set) { return set.Get(); }
        public void SetCallbacks(IDogActions instance)
        {
            if (m_Wrapper.m_DogActionsCallbackInterface != null)
            {
                @Bark.started -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Walk.started -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Die.started -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Die.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Die.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnDie;
                @Run.started -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_DogActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bark.started += instance.OnBark;
                @Bark.performed += instance.OnBark;
                @Bark.canceled += instance.OnBark;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Die.started += instance.OnDie;
                @Die.performed += instance.OnDie;
                @Die.canceled += instance.OnDie;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public DogActions @Dog => new DogActions(this);
    public interface IDogActions
    {
        void OnBark(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnDie(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
