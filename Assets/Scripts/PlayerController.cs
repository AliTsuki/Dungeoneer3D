using Cinemachine;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject CineCamObject;
    public GameObject CamObject;
    public float Acceleration = 25f;
    public float MaxSpeed = 7f;
    public float SpeedDecayRate = 0.9f;
    public float RotationSpeed = 0.1f;
    public Vector2 CamSpeed = new Vector2(1f, 0.01f);
    public bool PlayerAcclerating = false;

    private static PlayerControls Controls;
    private static GameObject Player;
    private static Rigidbody Rbody;
    private static CinemachineFreeLook CineCam;

    public Vector3 PlayerMovementVelocity;
    public float PlayerMovementMagnitude; // Debugging
    public float TargetVelocityMagnitude;
    public float Speed;
    public Vector3 CameraMovement;

    // Awake is called when the gameobject parent of this script is activated
    private void Awake()
    {
        Player = this.gameObject;
        Rbody = Player.GetComponent<Rigidbody>();
        CineCam = this.CineCamObject.GetComponent<CinemachineFreeLook>();
        Controls = new PlayerControls();
        Controls.Gameplay.Move.performed += this.Move_performed;
        Controls.Gameplay.Move.canceled += this.Move_canceled;
        Controls.Gameplay.RotateCamera.performed += this.RotateCamera_performed;
        Controls.Gameplay.RotateCamera.canceled += this.RotateCamera_canceled;
        Controls.Gameplay.ToggleMenu.performed += this.ToggleMenu_performed;
    }

    private void OnEnable()
    {
        Controls.Gameplay.Enable();
    }

    private void OnDisable()
    {
        Controls.Gameplay.Disable();
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.MovePlayer();
        this.RotateCamera();
    }

    private void MovePlayer()
    {
        this.PlayerMovementMagnitude = this.PlayerMovementVelocity.magnitude;
        this.TargetVelocityMagnitude = (this.PlayerMovementVelocity * this.Acceleration).magnitude;
        this.Speed = Rbody.velocity.magnitude;
        if(this.PlayerAcclerating == true)
        {
            this.Accelerate();
            this.RotatePlayer();
            CineCam.m_RecenterToTargetHeading.m_enabled = true;
        }
        else
        {
            this.DecayMovementSpeed();
            CineCam.m_RecenterToTargetHeading.m_enabled = false;
        }
    }

    private void RotatePlayer()
    {
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(this.PlayerMovementVelocity), this.RotationSpeed);
    }

    private void RotateCamera()
    {
        CineCam.m_XAxis.m_InputAxisValue = this.CameraMovement.x * this.CamSpeed.x;
        CineCam.m_YAxis.m_InputAxisValue = this.CameraMovement.y * this.CamSpeed.y;
        if(this.CameraMovement.magnitude > 0.1)
        {
            CineCam.m_RecenterToTargetHeading.m_enabled = false;
        }
    }

    private void Accelerate()
    {
        if(Rbody.velocity.magnitude < this.MaxSpeed)
        {
            Rbody.AddForce(this.PlayerMovementVelocity * this.Acceleration, ForceMode.Acceleration);
        }
        else
        {
            Rbody.velocity = Vector3.Lerp(Rbody.velocity, Vector3.ClampMagnitude(Rbody.velocity, this.MaxSpeed), this.SpeedDecayRate);
        }
    }

    private void DecayMovementSpeed()
    {
        if(this.PlayerMovementVelocity.sqrMagnitude > 0.01)
        {
            Vector3.Lerp(this.PlayerMovementVelocity, Vector3.zero, this.SpeedDecayRate);
        }
        else
        {
            this.PlayerMovementVelocity = Vector3.zero;
        }
    }

    private Quaternion IsolateYRotation(Quaternion q)
    {
        return Quaternion.Euler(0, q.eulerAngles.y, 0);
    }

    private void Move_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        this.PlayerMovementVelocity = this.IsolateYRotation(this.CamObject.transform.rotation) * new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
        this.PlayerAcclerating = true;
    }

    private void Move_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        this.PlayerAcclerating = false;
    }

    private void RotateCamera_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        this.CameraMovement = context.ReadValue<Vector2>();
    }

    private void RotateCamera_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        this.CameraMovement = Vector3.zero;
    }

    private void ToggleMenu_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        
    }
}
