using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using GameOfLife.Classes;

namespace GameOfLife
{
    public partial class MainWindow : Form
    {
        Board board;
        Thread startThread;
        bool start = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var main = this;
            board = new Board(ref main);
            board.InitGuiBoard();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            board.InitRandomBoard((int)NUDPercentage.Value);
            board.Update();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            board.Next();
            board.Update();
        }

        private void Start()
        {
            while (start)
            {
                board.Next();
                board.Update();
                Thread.Sleep(500);
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            start = true;
            startThread = new Thread(Start);
            startThread.Start();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            start = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            board.Stop();
            board.Update();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            board.Save();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            board.Load();
        }
    }
}
