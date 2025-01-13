using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private InputManager inputManager;
    [SerializeField] private float moveSpeed = 3;
    
    private void Start()
    {
        inputManager = new InputManager();
    }


    private void Update()
    {
        //recebe o valor de InputMananger
        float moveDirection = inputManager.Movement * Time.deltaTime * moveSpeed;
        //movimento
        transform.Translate(moveDirection, 0, 0);
    }
}
