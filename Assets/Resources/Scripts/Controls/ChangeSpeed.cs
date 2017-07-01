﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour {

    public PlayerControls _playerControls;
    public _manager _sceneManager;
    public ParticleSystem _boostParticle;
    public ParticleSystem _regParticles;

    private void Awake()
    {
        _sceneManager = GameObject.Find("UI").GetComponent<_manager>();
        _boostParticle = GameObject.Find("BoostParticles").GetComponent<ParticleSystem>();
        _boostParticle.Stop();
        _playerControls = GameObject.Find("Player").GetComponent<PlayerControls>();
    }

    public void SpeedUp()
    {
        if (_sceneManager._inMenu) return;
        _playerControls._boost = true;
        _boostParticle.Play();
    }

    public void SlowDown()
    {
        if (_sceneManager._inMenu) return;
        _playerControls._brake = true;
        _boostParticle.Stop();
    }

    public void ReturnToNormal()
    {
        _playerControls._boost = false;
        _playerControls._brake = false;
        _boostParticle.Stop();
    }
}
