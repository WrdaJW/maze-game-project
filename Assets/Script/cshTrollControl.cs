using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cshTrollControl : MonoBehaviour
{
	// Start is called before the first frame update
	// 추적할 대상 Object
	private Transform playerTr;
	// 추적할 Object
	private Transform tr;
	// 추적 Object에 적용된 NavMeshAgent 컴포넌트
	private NavMeshAgent nvAgent;

	private Animator ani;
	// Use this for initialization
	void Start()
	{
		ani = GetComponent<Animator>();
		nvAgent = GetComponent<NavMeshAgent>();
		tr = GetComponent<Transform>();
		playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

		//추적 Object에 적용된 NavMeshAgent 컴포넌트에 추적대상 설정         
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
