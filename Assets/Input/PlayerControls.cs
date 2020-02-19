// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

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
            ""name"": ""Gameplay"",
            ""id"": ""b6b4df22-d8bc-47e5-bd11-b9a1e0de0619"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""32cf4e55-19af-4a88-83bd-1f901508bdac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Camera Controller"",
                    ""type"": ""Value"",
                    ""id"": ""638f6c77-7e5f-48e6-8527-48c97ad93d8a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Camera Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""624d28e9-cf80-4668-bbef-77bc056f000b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Menu"",
                    ""type"": ""Button"",
                    ""id"": ""a5180922-0209-47da-85a3-0e4540b7d541"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f9e50bd6-2574-4360-854d-05362476445b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac99fa74-3e5b-4d33-b9b9-aee063097147"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Rotate Camera Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f358e2ba-9e76-4d3a-a13d-26207aa3007c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Toggle Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0142a64-c980-4c08-bdd6-3ed30f08cbfe"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Toggle Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ac023be-d1b5-4a45-9ef0-2a81ea592790"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Rotate Camera Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""f9394363-0448-4f5c-99a4-9e59cc064965"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f3fb7474-1320-4b22-9216-8d226ee5941d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cbe0cd71-3047-47e5-a2ed-e40f6742133e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cb9fea24-8f39-4df7-a212-517253a18678"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dd82deb1-133f-484f-9f4e-c2d611698ca4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""32eca773-f4ec-41f3-8260-650d9a0f0190"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""295c247c-b849-4341-be68-78bdb4418695"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38511a4e-d382-47a3-b077-2a0c2caef982"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Main Control Scheme"",
            ""bindingGroup"": ""Main Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
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
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_RotateCameraController = m_Gameplay.FindAction("Rotate Camera Controller", throwIfNotFound: true);
        m_Gameplay_RotateCameraMouse = m_Gameplay.FindAction("Rotate Camera Mouse", throwIfNotFound: true);
        m_Gameplay_ToggleMenu = m_Gameplay.FindAction("Toggle Menu", throwIfNotFound: true);
        // Menus
        m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
        m_Menus_Newaction = m_Menus.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_RotateCameraController;
    private readonly InputAction m_Gameplay_RotateCameraMouse;
    private readonly InputAction m_Gameplay_ToggleMenu;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @RotateCameraController => m_Wrapper.m_Gameplay_RotateCameraController;
        public InputAction @RotateCameraMouse => m_Wrapper.m_Gameplay_RotateCameraMouse;
        public InputAction @ToggleMenu => m_Wrapper.m_Gameplay_ToggleMenu;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @RotateCameraController.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCameraController;
                @RotateCameraController.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCameraController;
                @RotateCameraController.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCameraController;
                @RotateCameraMouse.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCameraMouse;
                @RotateCameraMouse.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCameraMouse;
                @RotateCameraMouse.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRotateCameraMouse;
                @ToggleMenu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnToggleMenu;
                @ToggleMenu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnToggleMenu;
                @ToggleMenu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnToggleMenu;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotateCameraController.started += instance.OnRotateCameraController;
                @RotateCameraController.performed += instance.OnRotateCameraController;
                @RotateCameraController.canceled += instance.OnRotateCameraController;
                @RotateCameraMouse.started += instance.OnRotateCameraMouse;
                @RotateCameraMouse.performed += instance.OnRotateCameraMouse;
                @RotateCameraMouse.canceled += instance.OnRotateCameraMouse;
                @ToggleMenu.started += instance.OnToggleMenu;
                @ToggleMenu.performed += instance.OnToggleMenu;
                @ToggleMenu.canceled += instance.OnToggleMenu;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private IMenusActions m_MenusActionsCallbackInterface;
    private readonly InputAction m_Menus_Newaction;
    public struct MenusActions
    {
        private @PlayerControls m_Wrapper;
        public MenusActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menus_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void SetCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenusActions @Menus => new MenusActions(this);
    private int m_MainControlSchemeSchemeIndex = -1;
    public InputControlScheme MainControlSchemeScheme
    {
        get
        {
            if (m_MainControlSchemeSchemeIndex == -1) m_MainControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Main Control Scheme");
            return asset.controlSchemes[m_MainControlSchemeSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotateCameraController(InputAction.CallbackContext context);
        void OnRotateCameraMouse(InputAction.CallbackContext context);
        void OnToggleMenu(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
