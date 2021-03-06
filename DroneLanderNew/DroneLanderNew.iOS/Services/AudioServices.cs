﻿using System;
using AVFoundation;
using DroneLanderNew.iOS.Services;
using DroneLanderNew.Services;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(AudioService))]
namespace DroneLanderNew.iOS.Services
{
    public class AudioService : IAudioService
    {
        private AVAudioPlayer _audioPlayer = null;
        public Action OnFinishedPlaying { get; set; }

        public AudioService()
        {
            var avSession = AVAudioSession.SharedInstance();
            avSession.SetCategory(AVAudioSessionCategory.Playback);

            NSError activationError = null;
            avSession.SetActive(true, out activationError);
        }

        public void AdjustVolume(double level)
        {
            float volume = (float)(level / 100.0);

            if (volume == 0.0) volume = 0.1f;

            _audioPlayer.SetVolume(volume, 0);
        }

        public void KillEngine()
        {
            _audioPlayer.SetVolume(0.0f, 0);
        }

        public void ToggleEngine()
        {
            if (_audioPlayer != null)
            {
                _audioPlayer.FinishedPlaying -= OnMediaCompleted;
                _audioPlayer.Stop();
                _audioPlayer = null;
            }
            else
            {
                string localUrl = "Sounds/engine.m4a";
                _audioPlayer = AVAudioPlayer.FromUrl(NSUrl.FromFilename(localUrl));
                _audioPlayer.SetVolume(0.1f, 0);
                _audioPlayer.FinishedPlaying += OnMediaCompleted;
                _audioPlayer.Play();
            }
        }

        private void OnMediaCompleted(object sender, AVStatusEventArgs e)
        {
            OnFinishedPlaying?.Invoke();
        }
    }
}