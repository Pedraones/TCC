using UnityEngine;

public class Player1Pessoa : MonoBehaviour
{
    [Header("Player")]
    public CharacterController controller;
    public Animator animator;
    
    [Range(0f, 50f)]
    public float velAndar;

    [Range(0f, 50f)]
    public float velCorrer;

    private float velAtual;

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

        bool correndo = Input.GetKey(KeyCode.LeftShift);
        velAtual = correndo ? velCorrer : velAndar;

        ChecarAnimacoes(correndo, playerInput);

        controller.Move(playerInput * velAtual * Time.deltaTime);
    }

    private void ChecarAnimacoes(bool correndo, Vector3 playerInput)
    {
        //verificação das condições das animações
        if (playerInput.magnitude > 0.1f)
        {
            animator.SetBool("Andar", true);
            animator.SetBool("Correr", correndo);
        }

        else
        {
            animator.SetBool("Andar", false);
            animator.SetBool("Correr", false);
        }
    }

}
