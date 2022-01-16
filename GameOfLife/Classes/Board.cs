using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameOfLife.Classes
{
    public class Board
    {
        #region Members
        private static Random rnd = new Random();
        private int[] neighbours = new int[Size * Size];
        private bool[] cells = new bool[Size * Size];
        private const int Width = 400, Height = 400;
        private readonly Point startPoint = new Point(0, 0);
        public static readonly int Size = 20;
        public readonly Color DeadCell = Color.Red;
        public readonly Color LivingCell = Color.Green;
        Button[] guiCells = new Button[Size * Size];
        MainWindow mainWindow;
        #endregion
        #region Ctor
        public Board(ref MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
        #endregion
        #region Properties
        public Button[] GUICells => guiCells;
        public bool[] Cells => cells;
        #endregion
        #region Methodes
        public void InitGuiBoard()
        {
            Button button;

            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    button = new Button();
                    button.Width = Width / Size;
                    button.Height = Height / Size;
                    button.Location = new Point(startPoint.X + x * button.Width,
                                                startPoint.Y + y * button.Height);
                    button.BackColor = cells[y * Size + x] ? LivingCell : DeadCell;
                    button.Click += Button_Click;
                    button.Tag = (y * Size + x).ToString();
                    guiCells[y * Size + x] = button;

                    mainWindow.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            cells[Convert.ToInt32(button.Tag.ToString())] = !cells[Convert.ToInt32(button.Tag.ToString())];
            button.BackColor = cells[Convert.ToInt32(button.Tag.ToString())] ? LivingCell : DeadCell;
        }
        public void Save()
        {
            StreamWriter sw;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Game Of Life File |*.gol";
            string path = "", decryptedMap = RunLengthEncoding.Decrypt(cells);

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
            }

            sw = new StreamWriter(path);
            sw.Write(decryptedMap);
            sw.Flush();
            sw.Close();
        }
        public void Load()
        {
            StreamReader streamReader;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Game Of Life File |*gol";
            string path = "", decryptedMap = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            streamReader = new StreamReader(path);
            decryptedMap = streamReader.ReadLine();
            streamReader.Close();

            cells = RunLengthEncoding.Encrypt(decryptedMap);
            Update();
        }
        public void InitRandomBoard(int percentage)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = WeightedRandom(percentage);
            }
        }
        private bool WeightedRandom(int percentage)
        {
            return rnd.Next(1, 100) <= percentage;
        }
        public void Update()
        {
            for (int i = 0; i < guiCells.Length; i++)
            {
                guiCells[i].BackColor = cells[i] ? LivingCell : DeadCell;
            }
        }
        public void Next()
        {
            for (int i = 0; i < neighbours.Length; i++)
            {
                neighbours[i] = 0;
            }

            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    #region UP
                    if (y - 1 >= 0)
                    {
                        if (x - 1 >= 0)
                        {
                            if (cells[(y - 1) * Size + (x - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(y - 1) * Size + (Size - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (x + 1 < Size)
                        {
                            if (cells[(y - 1) * Size + (x + 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(y - 1) * Size + (0)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (cells[(y - 1) * Size + (x + 0)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    else
                    {
                        if (x - 1 >= 0)
                        {
                            if (cells[(Size - 1) * Size + (x - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(Size - 1) * Size + (Size - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (x + 1 < Size)
                        {
                            if (cells[(Size - 1) * Size + (x + 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(Size - 1) * Size + (0)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (cells[(Size - 1) * Size + (x + 0)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    #endregion
                    #region DOWN
                    if (y + 1 < Size)
                    {
                        if (x - 1 >= 0)
                        {
                            if (cells[(y + 1) * Size + (x - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(y + 1) * Size + (Size - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (x + 1 < Size)
                        {
                            if (cells[(y + 1) * Size + (x + 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(y + 1) * Size + (0)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (cells[(y + 1) * Size + (x + 0)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    else
                    {
                        if (x - 1 >= 0)
                        {
                            if (cells[(0) * Size + (x - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(0) * Size + (Size - 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (x + 1 < Size)
                        {
                            if (cells[(0) * Size + (x + 1)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }
                        else
                        {
                            if (cells[(0) * Size + (0)])
                            {
                                neighbours[y * Size + x]++;
                            }
                        }

                        if (cells[(0) * Size + (x + 0)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    #endregion
                    #region Middle
                    if (x - 1 >= 0)
                    {
                        if (cells[(y + 0) * Size + (x - 1)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    else
                    {
                        if (cells[(y + 0) * Size + (Size - 1)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    if (x + 1 < Size)
                    {
                        if (cells[(y + 0) * Size + (x + 1)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    else
                    {
                        if (cells[(y + 0) * Size + (0)])
                        {
                            neighbours[y * Size + x]++;
                        }
                    }
                    #endregion
                }
            }

            for (int i = 0; i < cells.Length; i++)
            {
                if (neighbours[i] < 2 || neighbours[i] > 3)
                {
                    cells[i] = false;
                }

                else if (neighbours[i] == 3)
                {
                    cells[i] = true;
                }
            }

        }
        public void Stop()
        {
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = false;
            }
        }
        #endregion
    }
}
