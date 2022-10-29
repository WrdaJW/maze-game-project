using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cshTrollControl : MonoBehaviour
{
	// Start is called before the first frame update
	// ������ ��� Object
	private Transform playerTr;
	// ������ Object
	private Transform tr;
	// ���� Object�� ����� NavMeshAgent ������Ʈ
	private NavMeshAgent nvAgent;

	private Animator ani;
	// Use this for initialization
	void Start()
	{
		ani = GetComponent<Animator>();
		nvAgent = GetComponent<NavMeshAgent>();
		tr = GetComponent<Transform>();
		playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

		//���� Object�� ����� NavMeshAgent ������Ʈ�� ������� ����         
		nvAgent.destination = playerTr.position;
	}
	// Update is called once per frame     
	void Update()
	{
		nvAgent.destination = playerTr.position;
		ani.SetFloat("Speed", nvAgent.speed);
	}

	public void speedUp()
    {
		nvAgent.speed = nvAgent.speed + 0.7f;
		if(nvAgent.speed >= 4)
        {
			nvAgent.speed = 4.0f;
        }
    }

	public void speedDown()
	{
		nvAgent.speed = nvAgent.speed - 2.0f;
		if(nvAgent.speed <= 0)
        {
			nvAgent.speed = 1.0f;
        }
	}

}
