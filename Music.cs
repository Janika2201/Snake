﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Snake_game
{
    class Music
    {
        public Music()
        {            
        }

        public void MainMusic()
        {
            var mainMusic = new MediaPlayer();
            string url = @"C:\Users\morgo\source\repos\Snake-game\Music\Main.mp3";
            mainMusic.Open(new Uri(url, UriKind.Relative));
            mainMusic.Volume = 15;
            mainMusic.Play();
        }

        public void EatSound()
        {
            var eatsound = new MediaPlayer();
            string url = @"C:\Users\morgo\source\repos\Snake-game\Music\snakeatt.mp3";
            eatsound.Open(new Uri(url, UriKind.Relative));
            eatsound.Volume = 100;
            eatsound.Play();
        }
        public void GameOver()
        {
            var gameover = new MediaPlayer();
            string url = @"C:\Users\morgo\source\repos\Snake-game\Music\GameOver.mp3";
            gameover.Open(new Uri(url, UriKind.Relative));
            gameover.Volume = 100;
            gameover.Play();
        }
    }
}
