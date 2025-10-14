using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_game
{
    public partial class Form1 : Form
    {
        stGameStatus gameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2,
        }
        enum enWinner
        {
            Player1, Player2,
            Draw,
            GameInProgress
        }
        struct stGameStatus
        {

            public enWinner Winner;
            public bool GameOver;
            public byte PlayCount;
        }

        public Form1()
        {
            InitializeComponent();
        }
        void EndGame()
        {
            lblPlayer.Text = "Game Over";
            switch (gameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.Player2:
                    lblWinner.Text = "Player 2";
                    break;
                default:
                    lblWinner.Text = "Draw";
                    break;
            }
            MessageBox.Show($"Winner :{lblWinner.Text}", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetGame(); 

        }

        bool CheckPictureBoxs(PictureBox pic1,
            PictureBox pic2, PictureBox pic3)
        {
            if ((pic1.Tag != "?") && (pic1.Tag == pic2.Tag) && pic1.Tag == pic3.Tag)
            {
                pic1.BackColor = Color.YellowGreen;
                pic2.BackColor = Color.YellowGreen;
                pic3.BackColor = Color.YellowGreen;
                if (pic1.Tag.ToString() == "X")
                {
                    gameStatus.Winner = enWinner.Player1;

                }
                else
                {
                    gameStatus.Winner = enWinner.Player2;

                }
                gameStatus.GameOver = true;
                EndGame();
                return true;
            }
            gameStatus.GameOver = false;
            return false;
        }
        void CheckWinner()
        {
            if (CheckPictureBoxs(pictureBox1, pictureBox2, pictureBox3))
                return;
            if (CheckPictureBoxs(pictureBox4, pictureBox5, pictureBox6))
                return;
            if (CheckPictureBoxs(pictureBox7, pictureBox8, pictureBox9))
                return;
            if (CheckPictureBoxs(pictureBox1, pictureBox4, pictureBox7))
                return;
            if (CheckPictureBoxs(pictureBox2, pictureBox5, pictureBox8))
                return;
            if (CheckPictureBoxs(pictureBox3, pictureBox6, pictureBox9))
                return;
            if (CheckPictureBoxs(pictureBox1, pictureBox5, pictureBox9))
                return;
            if (CheckPictureBoxs(pictureBox3, pictureBox5, pictureBox7))
                return;
        }
        void ChangeImage(PictureBox pic)
        {
            if (pic.Tag == "?")
            {
                switch(PlayerTurn)
                {
                    case enPlayer.Player1:
                        pic.Image = Properties.Resources.X;
                        PlayerTurn = enPlayer.Player2;
                        lblPlayer.Text = "Player 2";
                        gameStatus.PlayCount++;
                        pic.Tag = "X";
                        CheckWinner();
                        break;
                        case enPlayer.Player2:
                        pic.Image = Properties.Resources.O;
                        PlayerTurn = enPlayer.Player1;
                        lblPlayer.Text = "Player 1";
                        gameStatus.PlayCount++;
                        pic.Tag = "O";
                        CheckWinner();
                        break;
                }
            }
            else
                MessageBox.Show("Wrong Choice", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (gameStatus.PlayCount == 9)
            {
                gameStatus.GameOver = true;
                gameStatus.Winner = enWinner.Draw;
                EndGame();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ChangeImage((PictureBox)sender);
        }

        void ResetGame()
        {
            this.Controls.Clear();
            InitializeComponent();
            gameStatus.PlayCount = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.White;
            Pen pen = new Pen(white, 10);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 350, 262, 670, 262);
            e.Graphics.DrawLine(pen, 350, 150, 670, 150);
            e.Graphics.DrawLine(pen, 440, 50, 440, 370);
            e.Graphics.DrawLine(pen, 575, 50, 575, 370);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show($"X = {}")
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X = {e.X}, Y = {e.Y}";
        }
    }

}
