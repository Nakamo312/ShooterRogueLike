using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Unit;
class PlayerInstance: MonoBehaviour
{
    [SerializeField]
    private PlayerStatsData _playerData;
    public Player player;

    private Controller _controller;
    private void Awake()
    {
        player = new Player(_playerData);
        _controller = GetComponent<Controller>();
        _controller.JumpHeight = player.Stats.jumpForce;
        _controller.WalkSpeed = player.Stats.moveSpeed;

    }

    private void Update()
    {
        
    }
}

