using Cinemachine;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject CineCamObject;
    public GameObject CamObject;
    public float MovementAcceleration = 25f;
    public float MovementMaxSpeed = 4f;
    public float MovementSpeedDecayRate = 0.9f;
    public float CharacterRotationSpeed = 0.1f;
    public bool CameraFollow = false;
    public Vector2 CamRotationSpeedController = new Vector2(1f, 1f);
    public Vector2 CamRotationSpeedMouse = new Vector2(1f, 1f);

    private static PlayerControls Controls;
    private static GameObject Player;
    private static Rigidbody Rbody;
    private static CinemachineFreeLook CineCam;
    private static Vector3 PlayerMovementVelocity;
    private static Vector3 CameraMovement;
    private static bool PlayerAcclerating = false;


    #region Monobehaviours
    // Awake is called when the script instance is being loaded.
    private void Awake()
    {
        Player = this.gameObject;
        Rbody = Player.GetComponent<Rigidbody>();
        CineCam = this.CineCamObject.GetComponent<CinemachineFreeLook>();
        Controls = new PlayerControls();
        Controls.Gameplay.Move.performed += this.Move_performed;
        Controls.Gameplay.Move.canceled += this.Move_canceled;
        Controls.Gameplay.RotateCameraController.performed += this.RotateCameraController_performed;
        Controls.Gameplay.RotateCameraController.canceled += this.RotateCameraController_canceled;
        Controls.Gameplay.RotateCameraMouse.performed += this.RotateCameraMouse_performed;
        Controls.Gameplay.RotateCameraMouse.canceled += this.RotateCameraMouse_canceled;
        Controls.Gameplay.ToggleMenu.performed += this.ToggleMenu_performed;
    }

    // This function is called when the object becomes enabled and active.
    private void OnEnable()
    {
        Controls.Gameplay.Enable();
    }

    // This function is called when the behaviour becomes disabled or inactive.
    private void OnDisable()
    {
        Controls.Gameplay.Disable();
    }

    // Start is called just before any of the update methods is called the first time.
    private void Start()
    {
        
    }

    // Update is called every frame.
    private void Update()
    {
        
    }

    // This function is called every fixed framerate frame.
    private void FixedUpdate()
    {
        this.Move();
        this.RotateCamera();
    }
    #endregion

    private void Move()
    {
        if(PlayerAcclerating == true)
        {
            this.Accelerate();
            this.Rotate();
            if(this.CameraFollow == true)
            {
                CineCam.m_RecenterToTargetHeading.m_enabled = true;
            }
        }
        else
        {
            this.DecayMovementSpeed();
            if(this.CameraFollow == true)
            {
                CineCam.m_RecenterToTargetHeading.m_enabled = false;
            }
        }
    }

    private void Rotate()
    {
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(PlayerMovementVelocity), this.CharacterRotationSpeed);
    }

    private void RotateCamera()
    {
        CineCam.m_XAxis.m_InputAxisValue = CameraMovement.x * this.CamRotationSpeedController.x;
        CineCam.m_YAxis.m_InputAxisValue = CameraMovement.y * this.CamRotationSpeedController.y;
        if(CameraMovement.magnitude > 0.1)
        {
            CineCam.m_RecenterToTargetHeading.m_enabled = false;
        }
    }

    private void Accelerate()
    {
        if(Rbody.velocity.magnitude < this.MovementMaxSpeed)
        {
            Rbody.AddForce(PlayerMovementVelocity * this.MovementAcceleration, ForceMode.Acceleration);
        }
        else
        {
            Rbody.velocity = Vector3.Lerp(Rbody.velocity, Vector3.ClampMagnitude(Rbody.velocity, this.MovementMaxSpeed), this.MovementSpeedDecayRate);
        }
    }

    private void DecayMovementSpeed()
    {
        if(PlayerMovementVelocity.sqrMagnitude > 0.01)
        {
            Vector3.Lerp(PlayerMovementVelocity, Vector3.zero, this.MovementSpeedDecayRate);
        }
        else
        {
            PlayerMovementVelocity = Vector3.zero;
        }
    }

    #region Inputs
    private void Move_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        PlayerMovementVelocity = this.CamObject.transform.rotation.IsolateYRotation() * new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
        PlayerAcclerating = true;
    }

    private void Move_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        PlayerAcclerating = false;
    }

    private void RotateCameraController_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        CameraMovement = context.ReadValue<Vector2>() * this.CamRotationSpeedController;
    }

    private void RotateCameraController_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        CameraMovement = Vector3.zero;
    }

    private void RotateCameraMouse_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        CameraMovement = context.ReadValue<Vector2>() * this.CamRotationSpeedMouse;
    }

    private void RotateCameraMouse_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        CameraMovement = Vector3.zero;
    }

    private void ToggleMenu_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }
    #endregion
}
