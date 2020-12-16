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
    public partial class FormGame : Form
    {
        FormStart formStart;
        Gamer gamerUser;
        GameProfile profileUser;
        Gamer gamerComputer;
        GameProfile profileComputer;
        Config config = new Config("Крестики-нолики");
        Bitmap bitmapCanvas;
        Graphics graphics;
        Pen pen;
        int[,] matrixCanvas = new int[3, 3];
        List<Figure> listFiguresForUser = new List<Figure>();
        List<Figure> listFiguresForComputer = new List<Figure>();

        Statistic statistic;
        public FormGame()
        {
            statistic = new Statistic();

            InitializeComponent();
            this.Visible = false;
            formStart = new FormStart();
            formStart.ShowDialog();
            if (!formStart.isStart)
            {
                Environment.Exit(0);
            }
            gamerUser = formStart.gamerUser;
            profileUser = formStart.gameProfile;
            if (gamerUser.figure == 1)
            {
                gamerComputer = new GamerComputer(0, 0);
            }
            else
            {
                gamerComputer = new GamerComputer(0, 1);
            }
            profileComputer = gamerComputer.Create();
            textBoxGamer1.Text = gamerUser.name;
            textBoxGamer2.Text = gamerComputer.name;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixCanvas[i,j] = -1;
                }
            }
        }

        private void updateCanvas()
        {
            bitmapCanvas = new Bitmap(pictureboxCanvas.Height, pictureboxCanvas.Width);
            graphics = Graphics.FromImage(bitmapCanvas);
            pen = new Pen(Color.Black);
            ILine lineH = new LineHorizontal(graphics, pen, 375);
            ILine clonedLineH1 = lineH.Clone();
            clonedLineH1.draw(0);
            ILine clonedLineH2 = lineH.Clone();
            clonedLineH2.draw(125);
            ILine clonedLineH3 = lineH.Clone();
            clonedLineH3.draw(250);
            ILine clonedLineH4 = lineH.Clone();
            clonedLineH4.draw(375);
            ILine lineV = new LineVertical(graphics, pen, 375);
            ILine clonedLineV1 = lineV.Clone();
            clonedLineV1.draw(0);
            ILine clonedLineV2 = lineV.Clone();
            clonedLineV2.draw(125);
            ILine clonedLineV3 = lineV.Clone();
            clonedLineV3.draw(250);
            ILine clonedLineV4 = lineV.Clone();
            clonedLineV4.draw(375);
            foreach (Figure figure in listFiguresForUser )
            {
                if (gamerUser.figure == 1)
                {
                    pen = new Pen(figure.color);
                    CrossFigure crossFigure = (CrossFigure)figure;
                    graphics.DrawLine(pen, crossFigure.l1x1, crossFigure.l1y1, crossFigure.l1x2, crossFigure.l1y2);
                    graphics.DrawLine(pen, crossFigure.l2x1, crossFigure.l2y1, crossFigure.l2x2, crossFigure.l2y2);
                }
                else
                {
                    pen = new Pen(figure.color);
                    ZeroFigure zeroFigure = (ZeroFigure)figure;
                    graphics.DrawEllipse(pen, zeroFigure.x, zeroFigure.y, zeroFigure.width, zeroFigure.height);
                }
            }
            foreach (Figure figure in listFiguresForComputer)
            {
                if (gamerComputer.figure == 1)
                {
                    pen = new Pen(figure.color);
                    CrossFigure crossFigure = (CrossFigure)figure;
                    graphics.DrawLine(pen, crossFigure.l1x1, crossFigure.l1y1, crossFigure.l1x2, crossFigure.l1y2);
                    graphics.DrawLine(pen, crossFigure.l2x1, crossFigure.l2y1, crossFigure.l2x2, crossFigure.l2y2);
                }
                else
                {
                    pen = new Pen(figure.color);
                    ZeroFigure zeroFigure = (ZeroFigure)figure;
                    graphics.DrawEllipse(pen, zeroFigure.x, zeroFigure.y, zeroFigure.width, zeroFigure.height);
                }
            }
            pictureboxCanvas.Image = bitmapCanvas;
        }

        private bool checkResult()
        {
            int res = 0;
            for (int i = 1; i <= 2; i++)
            {
                if ((matrixCanvas[0, 0] == i) && (matrixCanvas[0, 1] == i) && (matrixCanvas[0, 2] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[0, 1] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[2, 1] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[0, 2] == i) && (matrixCanvas[1, 2] == i) && (matrixCanvas[2, 2] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[0, 0] == i) && (matrixCanvas[1, 0] == i) && (matrixCanvas[2, 0] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[1, 0] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[1, 2] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[2, 0] == i) && (matrixCanvas[2, 1] == i) && (matrixCanvas[2, 2] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[0, 0] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[2, 2] == i))
                {
                    res = i;
                    break;
                }
                if ((matrixCanvas[2, 0] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[0, 2] == i))
                {
                    res = i;
                    break;
                }
            }
            if (res != 0)
            {
                if (res == 1)
                {

                    MessageBox.Show("Победил игрок " + gamerUser.name);
                    gamerUser.countWinds++;
                }
                else
                {
                    MessageBox.Show("Победил игрок " + gamerComputer.name);
                    gamerComputer.countWinds++;

                }
                listFiguresForUser = new List<Figure>();
                listFiguresForComputer = new List<Figure>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrixCanvas[i, j] = -1;
                    }
                }
                statistic.saves.Add(new String[3] { DateTime.Now.ToString(), gamerUser.countWinds.ToString(), gamerComputer.countWinds.ToString() });
                return true;
            }
            bool isDraw = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matrixCanvas[i, j] == -1)
                    {
                        isDraw = false;
                        break;
                    }
                }
            }
            if (isDraw)
            {
                MessageBox.Show("Ничья");
                gamerUser.countWinds++;
                gamerComputer.countWinds++;
                statistic.saves.Add(new String[3] { DateTime.Now.ToString(), gamerUser.countWinds.ToString(), gamerComputer.countWinds.ToString()});
                listFiguresForUser = new List<Figure>();
                listFiguresForComputer = new List<Figure>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrixCanvas[i, j] = -1;
                    }
                }
                return true;
            }
            return false;
        }

        private void pictureboxCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            int x = 0;
            int y = 0;
            if (args.X > 125)
            {
                x = 1;
                if (args.X > 250)
                {
                    x = 2;
                }
            }
            if (args.Y > 125)
            {
                y = 1;
                if (args.Y > 250)
                {
                    y = 2;
                }
            }

            if (matrixCanvas[x, y] == 1 || matrixCanvas[x, y] == 2)
            {
                return;
            }

            matrixCanvas[x, y] = 1;

            if (gamerUser.figure == 1)
            {
                listFiguresForUser.Add(new CrossFigure(new GreenFigure(), x, y));
            }
            else
            {
                listFiguresForUser.Add(new ZeroFigure(new RedFigure(), x, y, 105, 105));
            }
           
            updateCanvas();
            if (checkResult())
            {
                updateCanvas();
                labelResUser.Text = gamerUser.countWinds.ToString();
                labelResComputer.Text = gamerComputer.countWinds.ToString();
                return;
            }

            pictureboxCanvas_EmulatorClickComputer();
        }

        private void pictureboxCanvas_EmulatorClickComputer()
        {
            int x = 0;
            int y = 0;
            Random rnd = new Random();
            while (true)
            {
                x = rnd.Next(0, 3);
                y = rnd.Next(0, 3);
                if (matrixCanvas[x, y] == -1)
                {
                    matrixCanvas[x, y] = 2;
                    break;
                }
            }
            if (gamerComputer.figure == 1)
            {
                listFiguresForComputer.Add(new CrossFigure(new GreenFigure(), x, y));
            }
            else
            {
                listFiguresForComputer.Add(new ZeroFigure(new RedFigure(), x, y, 105, 105));
            }
            updateCanvas();
            if (checkResult())
            {
                updateCanvas();
                labelResComputer.Text = gamerComputer.countWinds.ToString();
                return;
            }
        }


        private void FormGame_Load(object sender, EventArgs e)
        {
            this.Text = config.nameApp;
            updateCanvas();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            string res = "";
            string fileName = "";
            try
            {
                if (MessageBox.Show("Использовать формат xml?\nВ противном случаем будет использоваться формат txt", "Формат записи результата", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FormatXml formatXml = new FormatXml();
                    res = statistic.write(formatXml, statistic.saves);
                    fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xml";
                }
                else
                {
                    FormatTxt formatTxt = new FormatTxt();
                    IFormatXml adapter = new Adapter(formatTxt);
                    res = statistic.write(adapter, statistic.saves);
                    fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".txt";
                }
                System.IO.File.WriteAllText(fileName, res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                throw;
            }
            Environment.Exit(0);
        }
    }
}