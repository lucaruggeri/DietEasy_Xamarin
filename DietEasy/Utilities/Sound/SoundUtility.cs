using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Media;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Utilities;

using DietEasy;

namespace Utilities
{
    public static class SoundUtility
    {
        public static void PlaySound____SOUNDPOOL(SoundsCategories soundId)
        {
            //SoundPool _player = new SoundPool(5, AudioManager.UseDefaultStreamType, 0);
            //int soundResourceId = 0;

            //if (_player.IsPlaying)
            //{
            //    _player.Stop();
            //}

            //if (soundId == SoundsCategories.Button)
            //{
            //    soundResourceId = Resource.Raw.button;
            //}
            //else if (soundId == SoundsCategories.CardFlip)
            //{
            //    soundResourceId = Resource.Raw.cardFlip;
            //}

            //if (soundResourceId > 0)
            //{
            //    _player = MediaPlayer.Create(Android.App.Application.Context, soundResourceId);
            //    _player.Start();
            //}
        }

        public static void PlaySound(SoundsCategories soundId)
        {
            MediaPlayer _player = new MediaPlayer();
            int soundResourceId = 0;

            if (_player.IsPlaying)
            {
                _player.Stop();
            }

            if (soundId == SoundsCategories.Button)
            {
                soundResourceId = Resource.Raw.button;
            }
            else if (soundId == SoundsCategories.CardFlip)
            {
                soundResourceId = Resource.Raw.cardFlip;
            }

            if (soundResourceId > 0)
            {
                _player = MediaPlayer.Create(Android.App.Application.Context, soundResourceId);
                _player.Start();
            }
        }
    }

    public enum SoundsCategories
    {
        CardFlip,
        Button
    };

}