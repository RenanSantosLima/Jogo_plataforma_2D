using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //private InputManager inputManager;
    [SerializeField] private float moveSpeed = 3;
    
    /*private void Start()
    {
        inputManager = new InputManager();
    }*/


    private void Update()
    {
        //recebe o valor de InputMananger
        float moveDirection = GameManager.Instance.inputManager.Movement;
        //movimento
        transform.Translate(moveDirection * Time.deltaTime * moveSpeed, 0, 0);
    }
}
