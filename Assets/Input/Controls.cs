// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""2eaebd74-ec91-457e-97a9-973a366227fb"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""242a714e-5f01-4c7d-ae58-c07e4b36de14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""36bc32c5-ed5a-405a-9c4b-46e3729fee23"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8d446a82-2484-431a-88df-58749646604a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1f034d5d-9958-44bf-8dae-64b734fb6f81"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""4cfc2052-a78b-4f6a-96ee-34538d959af4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""64930af3-3cc4-4a14-a7fe-66256efd522c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitMenu"",
                    ""type"": ""Button"",
                    ""id"": ""0102e45f-b6d1-490f-90a5-4fae43a605ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IncreaseSensY"",
                    ""type"": ""Button"",
                    ""id"": ""6c69d3c0-9a45-4cc1-8ad4-b445407f7c24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecreaseSensY"",
                    ""type"": ""Button"",
                    ""id"": ""f4061e31-7ddd-440e-8d12-06fc5911750b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""IncreaseSensX"",
                    ""type"": ""Button"",
                    ""id"": ""6422ba4f-7435-4cec-ba48-a34b201c62d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecreaseSensX"",
                    ""type"": ""Button"",
                    ""id"": ""7d372a84-6874-40e1-baca-6e6217f470d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7603ccfb-481a-4c8f-88f3-b36188756000"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8c87c78-cb7c-40b7-92be-87081c810de8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""77e98ec0-2761-424a-810a-2ee1bfb9c7a8"",
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
                    ""id"": ""3c6f1e72-8bdd-43c5-9ba7-fecf8c5172db"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""394366d7-65e9-4f9c-b3da-b3df41d0181c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""11c15651-9c76-4846-b84c-8b52758690be"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f70a2320-838c-4250-a4d1-8dc3deccd1f2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""88bc26ac-c839-4443-9351-290c8041686f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d6f4d33-6019-4d93-9dc9-b3eaa465178a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press(pressPoint=1)"",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99d891cf-1353-47e0-92a2-e0f0990e1483"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35649747-0c2a-4d30-959c-090dbb303bb8"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8db4d9b1-1264-4722-888d-975abe119bb2"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=10,y=10)"",
                    ""groups"": ""Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25eeaed3-966f-4876-b665-64312c1aa724"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""464829f3-8b6a-4e6b-a2b7-89dda1cefb86"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7da848f-dd3d-4f15-9b4e-8f8ab053d679"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e027221e-cc96-4ebc-a284-eb46fe983476"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90d966fd-0189-4946-91fc-f47162981476"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""IncreaseSensY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d85d1b81-1857-44b4-b6e4-563417d30558"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""IncreaseSensY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""759ff36f-aeb8-474e-a302-92c55ca7a957"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DecreaseSensY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18c5d235-2224-4105-86e7-6f93c5a8959c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""DecreaseSensY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4638a579-3e00-42e6-9632-d3feb314e316"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DecreaseSensX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""085e807a-10ee-4be6-9f7a-522385411ad0"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""DecreaseSensX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9205c3e4-f4c2-4466-9117-51c4cd7994b4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""IncreaseSensX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2f4a85c-769c-4279-befd-b83312eb43fa"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""IncreaseSensX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6bb2520-d7a9-4bd9-9dad-266367d0503b"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""065d763e-4e65-4256-9bd3-ad849aec74e0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ExitMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_Jump = m_PlayerInput.FindAction("Jump", throwIfNotFound: true);
        m_PlayerInput_Movement = m_PlayerInput.FindAction("Movement", throwIfNotFound: true);
        m_PlayerInput_Shoot = m_PlayerInput.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerInput_Aim = m_PlayerInput.FindAction("Aim", throwIfNotFound: true);
        m_PlayerInput_Melee = m_PlayerInput.FindAction("Melee", throwIfNotFound: true);
        m_PlayerInput_Pause = m_PlayerInput.FindAction("Pause", throwIfNotFound: true);
        m_PlayerInput_ExitMenu = m_PlayerInput.FindAction("ExitMenu", throwIfNotFound: true);
        m_PlayerInput_IncreaseSensY = m_PlayerInput.FindAction("IncreaseSensY", throwIfNotFound: true);
        m_PlayerInput_DecreaseSensY = m_PlayerInput.FindAction("DecreaseSensY", throwIfNotFound: true);
        m_PlayerInput_IncreaseSensX = m_PlayerInput.FindAction("IncreaseSensX", throwIfNotFound: true);
        m_PlayerInput_DecreaseSensX = m_PlayerInput.FindAction("DecreaseSensX", throwIfNotFound: true);
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

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private IPlayerInputActions m_PlayerInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInput_Jump;
    private readonly InputAction m_PlayerInput_Movement;
    private readonly InputAction m_PlayerInput_Shoot;
    private readonly InputAction m_PlayerInput_Aim;
    private readonly InputAction m_PlayerInput_Melee;
    private readonly InputAction m_PlayerInput_Pause;
    private readonly InputAction m_PlayerInput_ExitMenu;
    private readonly InputAction m_PlayerInput_IncreaseSensY;
    private readonly InputAction m_PlayerInput_DecreaseSensY;
    private readonly InputAction m_PlayerInput_IncreaseSensX;
    private readonly InputAction m_PlayerInput_DecreaseSensX;
    public struct PlayerInputActions
    {
        private @Controls m_Wrapper;
        public PlayerInputActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerInput_Jump;
        public InputAction @Movement => m_Wrapper.m_PlayerInput_Movement;
        public InputAction @Shoot => m_Wrapper.m_PlayerInput_Shoot;
        public InputAction @Aim => m_Wrapper.m_PlayerInput_Aim;
        public InputAction @Melee => m_Wrapper.m_PlayerInput_Melee;
        public InputAction @Pause => m_Wrapper.m_PlayerInput_Pause;
        public InputAction @ExitMenu => m_Wrapper.m_PlayerInput_ExitMenu;
        public InputAction @IncreaseSensY => m_Wrapper.m_PlayerInput_IncreaseSensY;
        public InputAction @DecreaseSensY => m_Wrapper.m_PlayerInput_DecreaseSensY;
        public InputAction @IncreaseSensX => m_Wrapper.m_PlayerInput_IncreaseSensX;
        public InputAction @DecreaseSensX => m_Wrapper.m_PlayerInput_DecreaseSensX;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnJump;
                @Movement.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Shoot.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnShoot;
                @Aim.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnAim;
                @Melee.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMelee;
                @Pause.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPause;
                @ExitMenu.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnExitMenu;
                @ExitMenu.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnExitMenu;
                @ExitMenu.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnExitMenu;
                @IncreaseSensY.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnIncreaseSensY;
                @IncreaseSensY.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnIncreaseSensY;
                @IncreaseSensY.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnIncreaseSensY;
                @DecreaseSensY.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnDecreaseSensY;
                @DecreaseSensY.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnDecreaseSensY;
                @DecreaseSensY.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnDecreaseSensY;
                @IncreaseSensX.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnIncreaseSensX;
                @IncreaseSensX.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnIncreaseSensX;
                @IncreaseSensX.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnIncreaseSensX;
                @DecreaseSensX.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnDecreaseSensX;
                @DecreaseSensX.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnDecreaseSensX;
                @DecreaseSensX.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnDecreaseSensX;
            }
            m_Wrapper.m_PlayerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @ExitMenu.started += instance.OnExitMenu;
                @ExitMenu.performed += instance.OnExitMenu;
                @ExitMenu.canceled += instance.OnExitMenu;
                @IncreaseSensY.started += instance.OnIncreaseSensY;
                @IncreaseSensY.performed += instance.OnIncreaseSensY;
                @IncreaseSensY.canceled += instance.OnIncreaseSensY;
                @DecreaseSensY.started += instance.OnDecreaseSensY;
                @DecreaseSensY.performed += instance.OnDecreaseSensY;
                @DecreaseSensY.canceled += instance.OnDecreaseSensY;
                @IncreaseSensX.started += instance.OnIncreaseSensX;
                @IncreaseSensX.performed += instance.OnIncreaseSensX;
                @IncreaseSensX.canceled += instance.OnIncreaseSensX;
                @DecreaseSensX.started += instance.OnDecreaseSensX;
                @DecreaseSensX.performed += instance.OnDecreaseSensX;
                @DecreaseSensX.canceled += instance.OnDecreaseSensX;
            }
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerInputActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnExitMenu(InputAction.CallbackContext context);
        void OnIncreaseSensY(InputAction.CallbackContext context);
        void OnDecreaseSensY(InputAction.CallbackContext context);
        void OnIncreaseSensX(InputAction.CallbackContext context);
        void OnDecreaseSensX(InputAction.CallbackContext context);
    }
}
