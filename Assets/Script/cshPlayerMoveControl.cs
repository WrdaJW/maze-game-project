using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerMoveControl : MonoBehaviour
{
    public float m_moveSpeed = 3.0f;
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }
    void Update()
    {

        PlayerMove();
    }

    void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 moveHorizontal = Vector3.right * h;
        Vector3 moveVertical = Vector3.forward * v;
        Vector3 velocity = (moveHorizontal + moveVertical).normalized;

        if (h == 0 && v == 0) ani.SetFloat("Speed", 0);
        else ani.SetFloat("Speed", m_moveSpeed);

        transform.LookAt(transform.position + velocity);

        transform.Translate(velocity * m_moveSpeed * Time.deltaTime, Space.World);
    }

}
