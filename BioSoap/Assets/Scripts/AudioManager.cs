using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class AudioManager : MonoBehaviour
{
    [Header("Music")]
    [SerializeField] private AudioSource _MainTheme;
    [SerializeField] private AudioSource _BattleTheme;
    [SerializeField] private AudioSource _GameOver;
    private bool _MainThemePlaying = false;
    private bool _BattleThemePlaying = false;
    private bool _GameOverPlaying = false;

    [Header("Sounds")]
    [SerializeField] private AudioSource _Reload;
    [SerializeField] private AudioSource _BovidBomb;
    [SerializeField] private AudioSource _BubbleBomb;
    [SerializeField] public AudioSource _POP;
    [SerializeField] private AudioSource _HeatDeath;
    [SerializeField] private AudioSource _DeathPoof;


    public void StartTitleMusic()
    {
        if (!_MainThemePlaying)
        {
            _MainTheme.Play();
            _BattleTheme.Stop();
            _MainTheme.volume = 0.5f;
            _BattleThemePlaying = false;
            _MainThemePlaying = true;
        }
    }

    public void StartGameMusic()
    {
        if (!_BattleThemePlaying)
        {
            _BattleTheme.Play();
            _MainTheme.Stop();
            _BattleTheme.volume = 0.5f;
            _MainThemePlaying = false;
            _BattleThemePlaying = true;
        }
    }
    public void PlayPOP()
    {
        _POP.Play();
    }
    public void PlayHate()
    {
        _HeatDeath.Play();
    }
    public void BBomb()
    {
        _BubbleBomb.Play();
    }
    public void BovidPlay()
    {
        _BovidBomb.Play();
    }
    public void Reload()
    {
        _Reload.Play();
    }
    public void Poofy()
    {
        _DeathPoof.Play();
    }
}