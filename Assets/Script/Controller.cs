//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Script/Controller.inputactions
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

public partial class @Controller : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""030040de-8e4d-4c0b-8d3d-e758f81b10e8"",
            ""actions"": [
                {
                    ""name"": ""DisableMenu"",
                    ""type"": ""Button"",
                    ""id"": ""59559419-67b2-4b7a-bfe0-f58a73e56789"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""468169af-4c1d-4cea-aa6b-addfe9c7397c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""c6d53209-abf1-49f4-9c8f-a2aa982a1331"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""8f2970b4-5e2e-41c5-a33b-9ca2878363aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c8d47b71-96c1-40da-a305-03db5f765c1e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DisableMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d51c884d-6550-454c-9d32-8ff779b7e2a5"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e9215bb-f5f6-4749-a47d-f02d0d2d0e5e"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97213522-556c-4c28-a3c7-d98b54c6cf42"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MainScene"",
            ""id"": ""746233da-cfea-42a4-b444-d8d910be5cf6"",
            ""actions"": [
                {
                    ""name"": ""EnableMenu"",
                    ""type"": ""Button"",
                    ""id"": ""f8bbfc9f-9cb0-47ad-94e3-2aeae4db462d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectPointer"",
                    ""type"": ""Button"",
                    ""id"": ""af2bcb20-28ff-47eb-9771-60f3f45d0296"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NextPointer"",
                    ""type"": ""Button"",
                    ""id"": ""4b71d825-2148-4c1d-a919-fc99e7e70aeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BackPointer"",
                    ""type"": ""Button"",
                    ""id"": ""afeccce2-9f61-4039-bee4-df44b7e9200e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TestInsert"",
                    ""type"": ""Button"",
                    ""id"": ""5e4ec871-4c7a-4565-8c49-140927903f00"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""131ae4a9-604c-4fd2-a2f7-1690f36d22c2"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70e57a06-b32e-4d64-a435-f9ca40193eee"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectPointer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc822080-1172-40e6-921b-85eac9030860"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextPointer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51a58f47-0842-4206-9390-c301fdee00b2"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackPointer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6770d529-0e96-457a-9bbb-9e0d4149ddf5"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TestInsert"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_DisableMenu = m_Menu.FindAction("DisableMenu", throwIfNotFound: true);
        m_Menu_Down = m_Menu.FindAction("Down", throwIfNotFound: true);
        m_Menu_Up = m_Menu.FindAction("Up", throwIfNotFound: true);
        m_Menu_Select = m_Menu.FindAction("Select", throwIfNotFound: true);
        // MainScene
        m_MainScene = asset.FindActionMap("MainScene", throwIfNotFound: true);
        m_MainScene_EnableMenu = m_MainScene.FindAction("EnableMenu", throwIfNotFound: true);
        m_MainScene_SelectPointer = m_MainScene.FindAction("SelectPointer", throwIfNotFound: true);
        m_MainScene_NextPointer = m_MainScene.FindAction("NextPointer", throwIfNotFound: true);
        m_MainScene_BackPointer = m_MainScene.FindAction("BackPointer", throwIfNotFound: true);
        m_MainScene_TestInsert = m_MainScene.FindAction("TestInsert", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_DisableMenu;
    private readonly InputAction m_Menu_Down;
    private readonly InputAction m_Menu_Up;
    private readonly InputAction m_Menu_Select;
    public struct MenuActions
    {
        private @Controller m_Wrapper;
        public MenuActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @DisableMenu => m_Wrapper.m_Menu_DisableMenu;
        public InputAction @Down => m_Wrapper.m_Menu_Down;
        public InputAction @Up => m_Wrapper.m_Menu_Up;
        public InputAction @Select => m_Wrapper.m_Menu_Select;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @DisableMenu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDisableMenu;
                @DisableMenu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDisableMenu;
                @DisableMenu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDisableMenu;
                @Down.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Up.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Select.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DisableMenu.started += instance.OnDisableMenu;
                @DisableMenu.performed += instance.OnDisableMenu;
                @DisableMenu.canceled += instance.OnDisableMenu;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // MainScene
    private readonly InputActionMap m_MainScene;
    private IMainSceneActions m_MainSceneActionsCallbackInterface;
    private readonly InputAction m_MainScene_EnableMenu;
    private readonly InputAction m_MainScene_SelectPointer;
    private readonly InputAction m_MainScene_NextPointer;
    private readonly InputAction m_MainScene_BackPointer;
    private readonly InputAction m_MainScene_TestInsert;
    public struct MainSceneActions
    {
        private @Controller m_Wrapper;
        public MainSceneActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @EnableMenu => m_Wrapper.m_MainScene_EnableMenu;
        public InputAction @SelectPointer => m_Wrapper.m_MainScene_SelectPointer;
        public InputAction @NextPointer => m_Wrapper.m_MainScene_NextPointer;
        public InputAction @BackPointer => m_Wrapper.m_MainScene_BackPointer;
        public InputAction @TestInsert => m_Wrapper.m_MainScene_TestInsert;
        public InputActionMap Get() { return m_Wrapper.m_MainScene; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainSceneActions set) { return set.Get(); }
        public void SetCallbacks(IMainSceneActions instance)
        {
            if (m_Wrapper.m_MainSceneActionsCallbackInterface != null)
            {
                @EnableMenu.started -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnEnableMenu;
                @EnableMenu.performed -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnEnableMenu;
                @EnableMenu.canceled -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnEnableMenu;
                @SelectPointer.started -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnSelectPointer;
                @SelectPointer.performed -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnSelectPointer;
                @SelectPointer.canceled -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnSelectPointer;
                @NextPointer.started -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnNextPointer;
                @NextPointer.performed -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnNextPointer;
                @NextPointer.canceled -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnNextPointer;
                @BackPointer.started -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnBackPointer;
                @BackPointer.performed -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnBackPointer;
                @BackPointer.canceled -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnBackPointer;
                @TestInsert.started -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnTestInsert;
                @TestInsert.performed -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnTestInsert;
                @TestInsert.canceled -= m_Wrapper.m_MainSceneActionsCallbackInterface.OnTestInsert;
            }
            m_Wrapper.m_MainSceneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EnableMenu.started += instance.OnEnableMenu;
                @EnableMenu.performed += instance.OnEnableMenu;
                @EnableMenu.canceled += instance.OnEnableMenu;
                @SelectPointer.started += instance.OnSelectPointer;
                @SelectPointer.performed += instance.OnSelectPointer;
                @SelectPointer.canceled += instance.OnSelectPointer;
                @NextPointer.started += instance.OnNextPointer;
                @NextPointer.performed += instance.OnNextPointer;
                @NextPointer.canceled += instance.OnNextPointer;
                @BackPointer.started += instance.OnBackPointer;
                @BackPointer.performed += instance.OnBackPointer;
                @BackPointer.canceled += instance.OnBackPointer;
                @TestInsert.started += instance.OnTestInsert;
                @TestInsert.performed += instance.OnTestInsert;
                @TestInsert.canceled += instance.OnTestInsert;
            }
        }
    }
    public MainSceneActions @MainScene => new MainSceneActions(this);
    public interface IMenuActions
    {
        void OnDisableMenu(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
    public interface IMainSceneActions
    {
        void OnEnableMenu(InputAction.CallbackContext context);
        void OnSelectPointer(InputAction.CallbackContext context);
        void OnNextPointer(InputAction.CallbackContext context);
        void OnBackPointer(InputAction.CallbackContext context);
        void OnTestInsert(InputAction.CallbackContext context);
    }
}
