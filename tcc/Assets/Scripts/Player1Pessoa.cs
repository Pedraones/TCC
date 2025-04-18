using UnityEngine;

public class Player1Pessoa : MonoBehaviour
{
    [Header("Player")]
    public CharacterController controller;
    [Range(0f, 50f)]
    public float velocidade;

    [Header("Camera")]
    public Transform cameraHolder;

    [Header("Outros")]
    private Vector3 playerInput;

    private void Update()
    {
        Movimentacao();
    }

    private void Movimentacao()
    {
        //input e movimentação do player
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontal, 0f, vertical);
        playerInput = transform.TransformDirection(playerInput);

        controller.Move(playerInput * velocidade * Time.deltaTime);
    }

}
