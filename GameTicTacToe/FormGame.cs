using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameTicTacToe
{
    public partial class FormGame : Form
    {
        /// <summary>
        /// Стартовое окно
        /// </summary>
        FormStart formStart;
        /// <summary>
        /// Игроок - поллльзователь
        /// </summary>
        Gamer gamerUser;
        /// <summary>
        /// Игровой профиль для пользователя 
        /// </summary>
        GameProfile profileUser;
        /// <summary>
        /// Игрок - компьютер
        /// </summary>
        Gamer gamerComputer;
        /// <summary>
        /// Игровой профиль для компьютера
        /// </summary>
        GameProfile profileComputer;
        /// <summary>
        /// Конфигурация
        /// </summary>
        Config config = new Config("Крестики-нолики");
        /// <summary>
        /// Изображение для игрового поля
        /// </summary>
        Bitmap bitmapCanvas;
        /// <summary>
        /// Графика для игрового поля
        /// </summary>
        Graphics graphics;
        /// <summary>
        /// Перо для рисования
        /// </summary>
        Pen pen;
        /// <summary>
        /// Матрица поля
        /// </summary>
        int[,] matrixCanvas = new int[3, 3];
        /// <summary>
        /// Коллекция фигур для игрока
        /// </summary>
        List<Figure> listFiguresForUser = new List<Figure>();
        /// <summary>
        /// Коллекция фигур для компьютера
        /// </summary>
        List<Figure> listFiguresForComputer = new List<Figure>();

        /// <summary>
        /// Записить статистики
        /// </summary>
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
            //если пользователь играет за одну фигуру, то компьютер за другую
            if (gamerUser.figure == 1)
            {
                gamerComputer = new GamerComputer(0, 0);
            }
            else
            {
                gamerComputer = new GamerComputer(0, 1);
            }
            profileComputer = gamerComputer.Create();
            //Заполняем текстовые боксы именами игроков
            textBoxGamer1.Text = gamerUser.name;
            textBoxGamer2.Text = gamerComputer.name;
            //заполняем поле пустыми клетками
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixCanvas[i,j] = -1;
                }
            }
        }
        /// <summary>
        /// Обновление игрового поля
        /// </summary>
        private void updateCanvas()
        {
            bitmapCanvas = new Bitmap(pictureboxCanvas.Height, pictureboxCanvas.Width);
            graphics = Graphics.FromImage(bitmapCanvas);
            pen = new Pen(Color.Black);
            //создаем горизонтальную линию
            ILine lineH = new LineHorizontal(graphics, pen, 375);
            //создаем клонируем ее и отрисовываем несколько раз
            ILine clonedLineH1 = lineH.Clone();
            clonedLineH1.draw(0);
            ILine clonedLineH2 = lineH.Clone();
            clonedLineH2.draw(125);
            ILine clonedLineH3 = lineH.Clone();
            clonedLineH3.draw(250);
            ILine clonedLineH4 = lineH.Clone();
            clonedLineH4.draw(375);
            //создаем вертикальную линию
            ILine lineV = new LineVertical(graphics, pen, 375);
            //клонируем ее и отрисосываем несколько раз
            ILine clonedLineV1 = lineV.Clone();
            clonedLineV1.draw(0);
            ILine clonedLineV2 = lineV.Clone();
            clonedLineV2.draw(125);
            ILine clonedLineV3 = lineV.Clone();
            clonedLineV3.draw(250);
            ILine clonedLineV4 = lineV.Clone();
            clonedLineV4.draw(375);

            //далее отрисовываем фигуры
            //форыч выполняет операторы(if) для каждого figure в экземпляре типа listFiguresForUser(коллекция фигур)
            foreach (Figure figure in listFiguresForUser )
            {
                //если у игрока фигура 1, то отрисовываем кретик
                if (gamerUser.figure == 1)
                {
                    pen = new Pen(figure.color);
                    CrossFigure crossFigure = (CrossFigure)figure;
                    graphics.DrawLine(pen, crossFigure.l1x1, crossFigure.l1y1, crossFigure.l1x2, crossFigure.l1y2);
                    graphics.DrawLine(pen, crossFigure.l2x1, crossFigure.l2y1, crossFigure.l2x2, crossFigure.l2y2);
                }
                //иначе рисуем круг
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

        /// <summary>
        /// Проверка результата
        /// </summary>
        /// <returns></returns>
        private bool checkResult()
        {
            //проверяем условие победы, проверяем все возможные комбинации 3-ех фигур подряд. 
            int res = 0;
            for (int i = 1; i <= 2; i++)
            {
                //левый столбец
                if ((matrixCanvas[0, 0] == i) && (matrixCanvas[0, 1] == i) && (matrixCanvas[0, 2] == i))
                {
                    res = i;
                    break;
                }
                //средняя строчка
                if ((matrixCanvas[0, 1] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[2, 1] == i))
                {
                    res = i;
                    break;
                }
                //верхная строчка
                if ((matrixCanvas[0, 2] == i) && (matrixCanvas[1, 2] == i) && (matrixCanvas[2, 2] == i))
                {
                    res = i;
                    break;
                }
                //нижняя строка
                if ((matrixCanvas[0, 0] == i) && (matrixCanvas[1, 0] == i) && (matrixCanvas[2, 0] == i))
                {
                    res = i;
                    break;
                }
                //средний столбец
                if ((matrixCanvas[1, 0] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[1, 2] == i))
                {
                    res = i;
                    break;
                }
                //правый столбец
                if ((matrixCanvas[2, 0] == i) && (matrixCanvas[2, 1] == i) && (matrixCanvas[2, 2] == i))
                {
                    res = i;
                    break;
                }
                //диагональ */*
                if ((matrixCanvas[0, 0] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[2, 2] == i))
                {
                    res = i;
                    break;
                }
                //диагональ *\*
                if ((matrixCanvas[2, 0] == i) && (matrixCanvas[1, 1] == i) && (matrixCanvas[0, 2] == i))
                {
                    res = i;
                    break;
                }
            }
            if (res != 0)
                //проверяем кто победил, если 1 - игрок, если 2 - компьютер
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
                //обновляем коллекции фигур
                listFiguresForUser = new List<Figure>();
                listFiguresForComputer = new List<Figure>();
                //чистим поле
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrixCanvas[i, j] = -1;
                    }
                }
                //записываем результаты игры в statistic для последующего вывода результатов в xml файл
                statistic.saves.Add(new String[3] { DateTime.Now.ToString(), gamerUser.countWinds.ToString(), gamerComputer.countWinds.ToString() });
                return true;
            }
            //проверяем, осталось ли на поле пустая клетка. Если есть пустая клетка - isDraw возвращает false
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
            //если пустых клеток не осталось, то обьявляем ничью
            if (isDraw)
            {
                MessageBox.Show("Ничья");
                //обновляем счетчики побед каждого из игроков
                gamerUser.countWinds++;
                gamerComputer.countWinds++;
                //записываем результаты в statistic
                statistic.saves.Add(new String[3] { DateTime.Now.ToString(), gamerUser.countWinds.ToString(), gamerComputer.countWinds.ToString()});
                //обновляем коллекции фигур
                listFiguresForUser = new List<Figure>();
                listFiguresForComputer = new List<Figure>();
                //очищаем поле
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

        /// <summary>
        /// Ход пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureboxCanvas_Click(object sender, EventArgs e)
        {
            //считываем клики мышки по клеткам
            MouseEventArgs args = (MouseEventArgs)e;
            int x = 0;
            int y = 0;
            //X от 0 до 125 - первый столбец, X от 125 до 250 - второй столбец, X > 250 - третий столбец
            if (args.X > 125)
            {
                x = 1;
                if (args.X > 250)
                {
                    x = 2;
                }
            }
            //Y от 0 до 125 - первая строка, Y от 125 до 250 - вторая строка, Y > 250 - третья строка
            if (args.Y > 125)
            {
                y = 1;
                if (args.Y > 250)
                {
                    y = 2;
                }
            }
            //проверяем, есть ли уже на этой клетке фигура одного из игроков, если да то return
            //
            if (matrixCanvas[x, y] == 1 || matrixCanvas[x, y] == 2)
            {
                return;
            }
            //если клетка пустая, то рисуем на ней фигуру игрока
            matrixCanvas[x, y] = 1;
            //добавляем фигуру игрока в коллекцию фигур
            if (gamerUser.figure == 1)
            {
                listFiguresForUser.Add(new CrossFigure(new GreenFigure(), x, y));
            }
            else
            {
                listFiguresForUser.Add(new ZeroFigure(new RedFigure(), x, y, 105, 105));
            }

            //обновляем холст
            updateCanvas();
            //если игра закончилась, то обновляем лейблы со статистикой
            //иначе ход компьютера
            if (checkResult())
            {
                updateCanvas();
                labelResUser.Text = gamerUser.countWinds.ToString();
                labelResComputer.Text = gamerComputer.countWinds.ToString();
                return;
            }

            pictureboxCanvas_EmulatorClickComputer();
        }

        /// <summary>
        /// Эмулятор хода компьютера
        /// </summary>
        private void pictureboxCanvas_EmulatorClickComputer()
        {
            //инициализируем
            int x = -1;
            int y = -1;

            //проверяем, можем ли собрать 3 фигуры подряд
            for (int i = 0; i < 3; i++)
            {
                //проверяем есть ли пара по горизонтали и можем ли мы поставить 3 фигуру
                if ((matrixCanvas[i, 0] == 2) && (matrixCanvas[i, 1] == 2) && (matrixCanvas[i, 2] == -1))
                {
                    matrixCanvas[i, 2] = 2;
                    x = i;
                    y = 2;
                    break;
                }
                //проверяем есть ли пара по горизонтали и можем ли мы поставить 3 фигуру в обратную сторону
                if ((matrixCanvas[i, 2] == 2) && (matrixCanvas[i, 1] == 2) && (matrixCanvas[i, 0] == -1))
                {
                    matrixCanvas[i, 0] = 2;
                    x = i;
                    y = 0;
                    break;
                }
                //проверяем есть ли пара по вертикали и можем ли мы поставить 3 фигуру
                if ((matrixCanvas[0, i] == 2) && (matrixCanvas[1, i] == 2) && (matrixCanvas[2, i] == -1))
                {
                    matrixCanvas[2, i] = 2;
                    x = 2;
                    y = i;
                    break;
                }
                //проверяем есть ли пара по вертикали и можем ли мы поставить 3 фигуру в обратную сторону
                if ((matrixCanvas[2, i] == 2) && (matrixCanvas[1, i] == 2) && (matrixCanvas[0, i] == -1))
                {
                    matrixCanvas[0, i] = 2;
                    x = 0;
                    y = i;
                    break;
                }
                //проверяем есть ли пара по диагонали №1 и можем ли мы поставить 3 фигуру
                if ((matrixCanvas[2, 0] == 2) && (matrixCanvas[1, 1] == 2) && (matrixCanvas[0, 2] == -1))
                {
                    matrixCanvas[0, 2] = 2;
                    x = 0;
                    y = 2;
                    break;
                }
                //проверяем есть ли пара по диагонали №1 и можем ли мы поставить 3 фигуру в обратную стоону
                if ((matrixCanvas[0, 2] == 2) && (matrixCanvas[1, 1] == 2) && (matrixCanvas[2, 0] == -1))
                {
                    matrixCanvas[2, 0] = 2;
                    x = 2;
                    y = 0;
                    break;
                }
                //проверяем есть ли пара по диагонали №2 и можем ли мы поставить 3 фигуру
                if ((matrixCanvas[2, 2] == 2) && (matrixCanvas[1, 1] == 2) && (matrixCanvas[0, 0] == -1))
                {
                    matrixCanvas[0, 0] = 2;
                    x = 0;
                    y = 0;
                    break;
                }
                //проверяем есть ли пара по диагонали №2 и можем ли мы поставить 3 фигуру в обратную стоону
                if ((matrixCanvas[0, 0] == 2) && (matrixCanvas[1, 1] == 2) && (matrixCanvas[2, 2] == -1))
                {
                    matrixCanvas[2, 2] = 2;
                    x = 2;
                    y = 2;
                    break;
                }
            }
            //алгоритм защиты, если игрок собрал 2 фигуры подряд, нужно помешать ему
            if (x == -1)
            {
                for (int i = 0; i < 3; i++)
                {
                    //проверяем есть ли у игрока пара по горизонтали и можем ли мы поставить 3 фигуру, чтобы помешать
                    if ((matrixCanvas[i, 0] == 1) && (matrixCanvas[i, 1] == 1) && (matrixCanvas[i, 2] == -1))
                    {
                        matrixCanvas[i, 2] = 2;
                        x = i;
                        y = 2;
                        break;
                    }
                    //проверяем есть ли у игрока пара по горизонтали и можем ли мы поставить 3 фигуру в обратную сторону
                    if ((matrixCanvas[i, 2] == 1) && (matrixCanvas[i, 1] == 1) && (matrixCanvas[i, 0] == -1))
                    {
                        matrixCanvas[i, 0] = 2;
                        x = i;
                        y = 0;
                        break;
                    }
                    //проверяем есть ли игрока по горизонтали пара через одну клетку, если да то нужно поставить в нее
                    if ((matrixCanvas[i, 2] == 1) && (matrixCanvas[i, 0] == 1) && (matrixCanvas[i, 1] == -1))
                    {
                        matrixCanvas[i, 1] = 2;
                        x = i;
                        y = 1;
                        break;
                    }
                    //проверяем есть ли у игрока пара по вертикали и можем ли мы поставить 3 фигуру, чтобы помешать
                    if ((matrixCanvas[0, i] == 1) && (matrixCanvas[1, i] == 1) && (matrixCanvas[2, i] == -1))
                    {
                        matrixCanvas[2, i] = 2;
                        x = 2;
                        y = i;
                        break;
                    }
                    //проверяем есть ли у игрока пара по вертикали и можем ли мы поставить 3 фигуру в обратную сторону
                    if ((matrixCanvas[2, i] == 1) && (matrixCanvas[1, i] == 1) && (matrixCanvas[0, i] == -1))
                    {
                        matrixCanvas[0, i] = 2;
                        x = 0;
                        y = i;
                        break;
                    }
                    //проверяем есть ли игрока по вертикали пара через одну клетку, если да то нужно поставить в нее
                    if ((matrixCanvas[2, i] == 1) && (matrixCanvas[0, i] == 1) && (matrixCanvas[1, i] == -1))
                    {
                        matrixCanvas[1, i] = 2;
                        x = 1;
                        y = i;
                        break;
                    }
                    //проверяем есть ли пара по диагонали №1 и можем ли мы поставить 3 фигуру
                    if ((matrixCanvas[2, 0] == 1) && (matrixCanvas[1, 1] == 1) && (matrixCanvas[0, 2] == -1))
                    {
                        matrixCanvas[0, 2] = 2;
                        x = 0;
                        y = 2;
                        break;
                    }
                    //проверяем есть ли пара по диагонали №1 и можем ли мы поставить 3 фигуру в обратную стоону
                    if ((matrixCanvas[0, 2] == 1) && (matrixCanvas[1, 1] == 1) && (matrixCanvas[2, 0] == -1))
                    {
                        matrixCanvas[2, 0] = 2;
                        x = 2;
                        y = 0;
                        break;
                    }
                    //проверяем есть ли пара по диагонали №2 и можем ли мы поставить 3 фигуру
                    if ((matrixCanvas[2, 2] == 1) && (matrixCanvas[1, 1] == 1) && (matrixCanvas[0, 0] == -1))
                    {
                        matrixCanvas[0, 0] = 2;
                        x = 0;
                        y = 0;
                        break;
                    }
                    //проверяем есть ли пара по диагонали №2 и можем ли мы поставить 3 фигуру в обратную стоону
                    if ((matrixCanvas[0, 0] == 1) && (matrixCanvas[1, 1] == 1) && (matrixCanvas[2, 2] == -1))
                    {
                        matrixCanvas[2, 2] = 2;
                        x = 2;
                        y = 2;
                        break;
                    }
                }
            }
            //смотрим, можем ли собрать 2 фигуры подряд и в перспективе собрать 3
            if (x == -1)
            {
                for (int i = 0; i < 3; i++)
                {
                    //проверяем возможность поставить 2 фигуру по горизонтали снизу вверх если есть перспектива поставить 3 фигуру
                    if ((matrixCanvas[i, 0] == 2) && (matrixCanvas[i, 1] == -1) && (matrixCanvas[i, 2] == -1))
                    {
                        matrixCanvas[i, 1] = 2;
                        x = i;
                        y = 1;
                        break;
                    }
                    //проверяем возможность поставить 2 фигуру по вертикали слева направо если есть перспектива поставить 3 фигуру
                    if ((matrixCanvas[0, i] == 2) && (matrixCanvas[1, i] == -1) && (matrixCanvas[2, i] == -1))
                    {
                        matrixCanvas[1, i] = 2;
                        x = 1;
                        y = i;
                        break;
                    }
                    //проверяем возможность поставить 2 фигуру по горизонтали сверху вниз если есть перспектива поставить 3 фигуру
                    if ((matrixCanvas[i, 2] == 2) && (matrixCanvas[i, 1] == -1) && (matrixCanvas[i, 0] == -1))
                    {
                        matrixCanvas[i, 1] = 2;
                        x = i;
                        y = 1;
                        break;
                    }
                    //проверяем возможность поставить 2 фигуру по вертикали справо налево если есть перспектива поставить 3 фигуру
                    if ((matrixCanvas[2, i] == 2) && (matrixCanvas[1, i] == -1) && (matrixCanvas[0, i] == -1))
                    {
                        matrixCanvas[1, i] = 2;
                        x = 1;
                        y = i;
                        break;
                    }
                    //проверяем возможность поставить горизонтально, если стоим в центре
                    if ((matrixCanvas[1, 1] == 2) && (matrixCanvas[1, 2] == -1) && (matrixCanvas[1, 0] == -1))
                    {
                        matrixCanvas[1, 2] = 2;
                        x = 1;
                        y = 2;
                        break;
                    }
                    //проверяем возможность поставить вертикально, если стоим в центре
                    if ((matrixCanvas[1, 1] == 2) && (matrixCanvas[2, 1] == -1) && (matrixCanvas[0, 1] == -1))
                    {
                        matrixCanvas[2, 1] = 2;
                        x = 2;
                        y = 1;
                        break;
                    }
                    //посколько центр в самом начале игры занят либо игроком, либо компьютером, то
                    //проверяем возможность поставить 2 фигуру по диагонали №2 если есть перспектива поставить 3 фигуру
                    if ((matrixCanvas[1, 1] == 2) && (matrixCanvas[2, 0] == -1) && (matrixCanvas[0, 2] == -1))
                    {
                        matrixCanvas[0, 2] = 2;
                        x = 0;
                        y = 2;
                        break;
                    }
                    //проверяем возможность поставить 2 фигуру по диагонали №1 если есть перспектива поставить 3 фигуру
                    if ((matrixCanvas[1, 1] == 2) && (matrixCanvas[0, 0] == -1) && (matrixCanvas[2, 2] == -1))
                    {
                        matrixCanvas[2, 2] = 2;
                        x = 2;
                        y = 2;
                        break;
                    }
                }
            }
            //поскольку лучший выбор для первого хода принято считать центр - первым ходом компьютер ставит свою фигуру на центр, если это возможно
            if (matrixCanvas[1, 1] == -1)
            {
                matrixCanvas[1, 1] = 2;
                x = 1;
                y = 1;
            }
            //иначе занимаем край
            else
            {
                if ((matrixCanvas[1, 1] == 1) && (matrixCanvas[2, 2] != 2))
                {
                    matrixCanvas[2, 2] = 2;
                    x = 2;
                    y = 2;
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

        //кнопка выхода
        private void buttonExit_Click(object sender, EventArgs e)
        {
            string res = "";
            string fileName = "";
            try
            {
                //если пользователь решил использовать xml
                if (MessageBox.Show("Использовать формат xml?\nВ противном случаем будет использоваться формат txt", "Формат записи результата", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //создаем хмл-докумнет со статистикой
                    FormatXml formatXml = new FormatXml();
                    res = statistic.write(formatXml, statistic.saves);
                    //генерируем название файла
                    fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".xml";
                }
                //иначе
                else
                {
                    //создаем тхт-файл
                    FormatTxt formatTxt = new FormatTxt();
                    IFormatXml adapter = new Adapter(formatTxt);
                    res = statistic.write(adapter, statistic.saves);
                    fileName = DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".txt";
                }
                //записываем статистику в файл
                System.IO.File.WriteAllText(fileName, res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                throw;
            }
            Application.Exit();
        }
    }
}