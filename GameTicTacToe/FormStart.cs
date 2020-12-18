using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTicTacToe
{
    public partial class FormStart : Form
    {
        /// <summary>
        /// Игровой персонаж
        /// </summary>
        public Gamer gamerUser { get; set; }
        /// <summary>
        /// Игровой профиль пользователя
        /// </summary>
        public GameProfile gameProfile { get; set; }
        /// <summary>
        /// Старт игры
        /// </summary>
        public bool isStart;
        /// <summary>
        /// Начать игру
        /// </summary>
        /// <param name="_gameProfile"></param>
        public FormStart()
        {
            isStart = false;

            InitializeComponent();
            radiobuttonCross.Checked = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textboxName.Text == "")
            {
                MessageBox.Show("Введите имя", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int option = 1;
            if (radiobuttonCross.Checked)
            {
                option = 1;
            }
            if (radiobuttonZero.Checked)
            {
                option = 0;
            }
            gamerUser = new GamerUser(1, textboxName.Text, option);
            gameProfile = gamerUser.Create();

            isStart = true;
            this.Close();
        }
    }
}
