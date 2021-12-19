using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.Unicode;
using System.Text.Encodings;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;


namespace labapp
{
    public partial class prmain : Form
    {

        #region main
        public prmain()
        {
            InitializeComponent();
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        string PuzzleWord = "";
        const int wordLength = 4;
        int stepCount = 0;
        private void prmain_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region 1
        public string abcl = "abcdefghijklmnopqrstuvwxyz";
        public string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string nums = "1234567890";

        //1lb
        private void genpass1_Click_1(object sender, EventArgs e) //генерация пароля
        {
            if (Lenght.Text == "")
                MessageBox.Show("Ошибка. Не введена длина строки!");
            try
            {
                var A = string.Empty;
                if (checkBox1.Checked)
                {
                    A += "фбвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                }
                if (checkBox2.Checked)
                {
                    A += "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                }
                if (checkBox3.Checked)
                {
                    A += "abcdefghijklmnopqrstuvwxyz";
                }
                if (checkBox4.Checked)
                {
                    A += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }
                if (checkBox5.Checked)
                {
                    A += "-= _ + */\\\"\'#@&!%^;:(){}[]?";
                }
                if (checkBox6.Checked)
                {
                    A += "1234567890";
                }
                if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
                {
                    MessageBox.Show("Задайте хотя-бы 1 параметр пароля!");
                }

                var random = new Random();
                var password = string.Empty;
                var L = Convert.ToInt32(Lenght.Text);
                for (int i = 0; i < L; i++)
                    password += A[random.Next(A.Length)];
                genresult1.Text = password;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка! Не задана длинна пароля!");
            }
        }

        private void genpass13_Click_1(object sender, EventArgs e)  // генерация по заданию 2(1)
        {
            try
            {
                var nums = "1234567890";
                var abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                var symb = "{!#$%&'()*}";
                var random = new Random();
                var password1 = string.Empty;
                var password2 = string.Empty;
                var password3 = string.Empty;
                for (int i = 0; i < 2; i++)
                    password1 += nums[random.Next(nums.Length)];
                for (int i = 0; i < 6; i++)
                    password1 += abc[random.Next(nums.Length)];
                for (int i = 0; i < 3; i++)
                    password1 += symb[random.Next(nums.Length)];
                genresult13.Text = password1 + password2 + password3;
            }
            catch
            {

            }
        }

        private void genpass11_Click_1(object sender, EventArgs e) //генерация по заданию 2(2)
        {
            try
            {
                var random = new Random();
                var password1 = string.Empty;
                var password2 = string.Empty;
                var password3 = string.Empty;
                for (int i = 0; i < 4; i++)
                    password1 += abcl[random.Next(nums.Length)];
                for (int i = 0; i < 6; i++)
                    password1 += abc[random.Next(nums.Length)];
                for (int i = 0; i < 2; i++)
                    password1 += nums[random.Next(nums.Length)];
                genresult11.Text = password1 + password2 + password3;
            }
            catch
            {

            }
        }
        private void genpass3_Click_1(object sender, EventArgs e) //генерация по заданию 2(2)
        {
            try
            {
                var random = new Random();
                var password1 = string.Empty;
                var password2 = string.Empty;
                var password3 = string.Empty;
                for (int i = 0; i < 4; i++)
                    password1 += abcl[random.Next(nums.Length)];
                for (int i = 0; i < 6; i++)
                    password1 += abc[random.Next(nums.Length)];
                for (int i = 0; i < 2; i++)
                    password1 += nums[random.Next(nums.Length)];
                genresult3.Text = password1 + password2 + password3;
            }
            catch
            {
                
            }
        }
        #endregion

        #region 2
        private void backbut_Click(object sender, EventArgs e)
        {
            this.Close();
            main open = new main();
            open.Show();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void zd1_Click(object sender, EventArgs e)
        {
            panelmainzw.Visible = false;
            erstepanelubung.Visible = true;

        }

        private void backzwaipanel_Click(object sender, EventArgs e)
        {
            erstepanelubung.Visible = false;
            panelmainzw.Visible = true;
        }

        //2 Magici
        private void encrypt_Click_1(object sender, EventArgs e)
        {
            resultshifrt.Text = "";

            if (encrypt_text.Text == "" || encrypt_text.Text == "Введите сообщение:")
            {
                MessageBox.Show("Вы ничего не ввели!");
                return;
            }

            string message = encrypt_text.Text;
            int k = (int)Math.Ceiling(Math.Sqrt(message.Length));
            if (k < 3)
            {
                while (k < 3)
                {
                    k++;
                }
            }

            int[,] magicalSquare = new int[k, k];
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    magicalSquare[i, j] = k * (((i + 1) + (j + 1) - 1 + (k / 2)) % k) + (((i + 1) + 2 * (j + 1) - 2) % k) + 1;
                }
            }
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    if ((magicalSquare[i, j] - 1) < message.Length)
                    {
                        resultshifrt.Text += message[magicalSquare[i, j] - 1];
                    }
                }
            }
        }

        private void descrypt_Click(object sender, EventArgs e)
        {
            resultrashifrt.Text = "";

            if (dectypt_text.Text == "" || dectypt_text.Text == "Введите сообщение:")
            {
                MessageBox.Show("Вы ничего не ввели!");
                return;
            }

            string message = dectypt_text.Text;
            int k = (int)Math.Ceiling(Math.Sqrt(message.Length));
            if (k < 3)
            {
                while (k < 3)
                {
                    k++;
                }
            }

            int[,] magicalSquare = new int[k, k];
            for (int j = 0; j < k; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    magicalSquare[j, i] = k * (((i + 1) + (j + 1) - 1 + (k / 2)) % k) + (((i + 1) + 2 * (j + 1) - 2) % k) + 1;
                }
            }

            char[,] messageToDecrypt = new char[k, k];
            int indexFill = 0;
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (magicalSquare[i, j] > message.Length)
                    {
                        continue;
                    }
                    else
                    {
                        messageToDecrypt[i, j] = message[indexFill];
                        indexFill++;
                    }
                }
            }

            int indexDecrypt = 1;
            while (indexDecrypt <= message.Length)
            {
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        if (indexDecrypt == magicalSquare[i, j])
                        {
                            resultrashifrt.Text += messageToDecrypt[i, j];
                            indexDecrypt++;
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            erstepanelubung.Visible = false;
            panel3.Visible = false;
            panelmainzw.Visible = true;
        }

        private void zd2_Click(object sender, EventArgs e)
        {
            erstepanelubung.Visible = false;
            panel3.Visible = true;
            panelmainzw.Visible = false;
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            int cols1 = (int)Math.Ceiling(Math.Sqrt(s1.Length + 1)); //столбец в матрице
            int rows1 = (int)Math.Ceiling((s1.Length + 1) / (double)cols1); //строка в матрице + округление вверх 
            dataGridView1.RowCount = rows1; //количество строк 
            dataGridView1.ColumnCount = cols1; //количество столбцов 

            for (int i = 0; i < cols1; i++) //столбец
            {
                for (int j = 0; j < rows1; j++)
                {
                    if (s1.Length > i * rows1 + j)
                    {
                        dataGridView1[i, j].Value = s1[i * rows1 + j];
                    }
                    else
                    {
                        dataGridView1[i, j].Value = "";
                    }
                }
            }

            StringBuilder sb1 = new StringBuilder(); //работа со строками

            for (int j = 0; j < rows1; j++)
            {
                for (int i = 0; i < cols1; i++)
                {
                    sb1.Append(dataGridView1[i, j].Value.ToString()); //заполняем таблицу
                }
            }
            textBox2.Text = sb1.ToString();//выводим шифр
        }
        #endregion

        #region 3

     
        double[] arr2 = new double[15] { 1, 0.1, 0.01, 0.001, 0.0001, 0.00001, 0.000001, 0.0000001, 0.00000001, 0.000000001, 0.0000000001, 0.00000000001, 0.000000000001, 0.0000000000001, 0.0000000000001 };
        private void button2_Click(object sender, EventArgs e) // шифратор Цезарь
        {
            shiftresult.Text = "";
            int move = 0;
            string[] array = new string[] { "а", "б", "в",
                    "г", "д", "е", "ё", "ж",
                    "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с",
                    "т", "у", "ф", "х",
                    "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            try
            {
                move = Convert.ToInt32(keyshif.Text);
                if (move > 33)
                {
                    while(move > 33)
                    {
                        move -= 33;
                    }
                }
                if (move < 0)
                {
                    while(move < 0)
                    {
                        move += 33;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Установите ключ шифрования!");
                return;
            }

            string[] array2;
            array2 = array.Skip(move).Concat(array.Take(move)).ToArray();

            foreach (string element in array2)
            {

            }

            string text = messageshifr.Text;
            foreach (char bykva in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (bykva.ToString().ToLower() == array[i])
                    {
                        shiftresult.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (bykva.ToString() == " " || bykva.ToString() == "." ||
                        bykva.ToString() == "," || bykva.ToString() == ":" ||
                        bykva.ToString() == ";" || bykva.ToString() == "?" ||
                        bykva.ToString() == "!")
                        {
                            shiftresult.Text += " ";
                            break;
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //расшифратор (просто минус значение ключа)
        {
            rasshresult.Text = "";
            int move = 0;

            string[] array = new string[] { "а", "б", "в",
                    "г", "д", "е", "ё", "ж",
                    "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с",
                    "т", "у", "ф", "х",
                    "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            try
            {
                move = Convert.ToInt32(keyshif.Text);
                if (move > 33)
                {
                    while (move > 33)
                    {
                        move -= 33;
                    }
                }
                if (move < 0)
                {
                    while (move < 0)
                    {
                        move += 33;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Установите ключ расшифрования!");
                return;
            }

            move = 33 - move;//вся расшифровка
            string[] array2;
            array2 = array.Skip(move).Concat(array.Take(move)).ToArray();

            foreach (string element in array2)
            {

            }

            string text = messagerassh.Text;
            foreach (char bykva in text)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (bykva.ToString().ToLower() == array[i])
                    {
                        rasshresult.Text += array2[i];
                        break;
                    }
                    else
                    {
                        if (bykva.ToString() == " " || bykva.ToString() == "." ||
                        bykva.ToString() == "," || bykva.ToString() == ":" ||
                        bykva.ToString() == ";" || bykva.ToString() == "?" ||
                        bykva.ToString() == "!")
                        {
                            rasshresult.Text += " ";
                            break;
                        }
                    }
                }
            }
        }
        //3.2 _ 3.3
        private const bool DEBUG = true;


        private static string alph = "абвгдеёжзийклмнопрстухфцчшщъыьэюя .,";

        private static string GetAlph(string arg)
        {
            string a_ = "abcdefghijklmnoprstuvwxyz".ToUpper();
            string a = string.Empty;
            for (int i = 0; i < a_.Length; i++)
            {
                if (arg.IndexOf(a_[i]) == -1)
                    a += a_[i];
            }

            return a;
        }


        //ТРИСЕМУС
        private void resultbuttonT_Click(object sender, EventArgs e)//шифровка
        {
            string str = Tencrypt.Text;

            if (str == null) MessageBox.Show("Введите сообщение!");
            string cipher = string.Empty;
            int k = 0;
            //коэфы
            int a = int.Parse(Akof.Text), b = int.Parse(Bkof.Text), c = int.Parse(Ckof.Text);
            if (Akof.Text == "" || Bkof.Text == "" || Ckof.Text == "")
            {
                MessageBox.Show("Вы не ввели коэффициенты!");
            }
            for (int i = 0; i < str.Length; i++)//да мы гоним это ралли
            {
                int index = alph.IndexOf(str[i]); //m
                k = a * i * i + b * i + c; // чистая формула k
                cipher += alph[(index + k) % alph.Length]; //формула L
            }

            Pencrypt.Text = cipher.ToUpper();//поднимаем выводим
        }
        private void resultbuttonP_Click(object sender, EventArgs e)//расшифровка
        {
            string str = Tdescrypt.Text;

            if (str == null) MessageBox.Show("Введите сообщение!");
            string cipher = string.Empty;
            str = str.ToLower();//опускаем работаем
            int k = 0;
            int a = int.Parse(Akof.Text), b = int.Parse(Bkof.Text), c = int.Parse(Ckof.Text);
            if(Akof.Text == "" || Bkof.Text == "" || Ckof.Text == "")
            {
                MessageBox.Show("Вы не ввели коэффициенты!");
            }

            for (int i = 0; i < str.Length; i++)//да мы гоним это ралли
            {
                int index = alph.IndexOf(str[i]);
                k = Math.Abs(a - alph.Length) * i * i + Math.Abs(b - alph.Length) * i + Math.Abs(c - alph.Length);//та же формула k только берем модуль от разности с длинной алфавита и получаем обратную ей букву
                cipher += alph[(index + k) % alph.Length]; // формула L без изменений
            }

            Pdescrypt.Text = cipher;
        }

        private void butdrei1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dritteundzweipanel.Visible = false;
            panel2.Visible = true;
            panelPlaefer.Visible = false;
        }

        private void butdrai2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dritteundzweipanel.Visible = true;
            panel2.Visible = false;
            panelPlaefer.Visible = false;
        }
        //playfair

        public abstract class PlayFairSettings
        {
            protected HashSet<char> HsAlphabet { get; private set; }
            protected Dictionary<char, char> Replaces { get; private set; }

            protected abstract char[] AlphabetChars { get; }

            /// <summary>Число столбцов в матрице</summary>
            public abstract int Columns { get; }

            /// <summary>Число строк в матрице</summary>
            public abstract int Rows { get; }

            /// <summary>Символ-заменитель</summary>
            public abstract char Replacer { get; }

            /// <summary>Алфавит</summary>
            public IEnumerable<char> Alphabet
            {
                get
                {
                    char[] chars = AlphabetChars;
                    foreach (var c in chars)
                        yield return c;
                }
            }

            public PlayFairSettings()
            {
                HsAlphabet = new HashSet<char>();
                Replaces = new Dictionary<char, char>();

                // Переносим символы алфавита в хэштаблицу, чтобы 
                // убрать повторяющиеся значения и быстро определять
                // принадлежит символ алфавиту или нет
                foreach (var c in AlphabetChars)
                    HsAlphabet.Add(c);
            }

            /// <summary>Возвращает символ после всех преобразований</summary>
            /// <remarks>Если символ не принадлежит алфавиту, будет поставлен Replacer.</remarks>
            public char GetChar(char Char)
            {
                Char = System.Char.ToLower(Char);
                Char = Replaces.ContainsKey(Char) ? Replaces[Char] : Char;
                return HsAlphabet.Contains(Char) ? Char : Replacer;
            }
        }
        public class PlayFair
        {
            struct TablePosition
            {
                public int Row;
                public int Column;

                public TablePosition(int Row, int Column)
                {
                    this.Row = Row;
                    this.Column = Column;
                }
            }

            char[,] Matrix;
            Dictionary<char, TablePosition> Positions; // Позиции символов в матрице

            public PlayFairSettings Settings { get; private set; }
            public string Key { get; private set; }

            public PlayFair(PlayFairSettings Settings, string Key)
            {
                this.Settings = Settings;
                this.Key = Key;

                // Формирование матрицы
                Positions = new Dictionary<char, TablePosition>();
                var items = MatrixItems().GetEnumerator();
                Matrix = new char[Settings.Rows, Settings.Columns];
                for (int r = 0; r < Settings.Rows; r++)
                {
                    for (int c = 0; c < Settings.Columns; c++)
                    {
                        if (items.MoveNext())
                        {
                            Matrix[r, c] = items.Current;
                            Positions.Add(items.Current, new TablePosition(r, c));
                        }
                        else throw new ArgumentException("Алфавит слишком маленький");
                    }
                }
            }

            /// <summary> Перечисление элементов матрицы </summary>
            IEnumerable<char> MatrixItems()
            {
                HashSet<char> used = new HashSet<char>();

                // Сначала пишем символы ключа
                foreach (char c in Key)
                {
                    char rc = Settings.GetChar(c);
                    if (!used.Contains(rc))
                    {
                        used.Add(rc);
                        yield return rc;
                    }
                }

                // Теперь оставшиеся символы алфавита
                foreach (char c in Settings.Alphabet)
                {
                    if (!used.Contains(c))
                    {
                        used.Add(c);
                        yield return c;
                    }
                }
            }

            /// <summary>
            ///     Разбиаение текста на символы по биграммам.
            ///     Replacer выкидывается
            /// </summary>
            public IEnumerable<char> Bigrams(string Text)
            {
                char prev = '\0';  // Храним перывй символ биграммы
                bool even = false; // если второй символ биграммы
                foreach (char c in Text)
                {
                    // Преобразуем символ из текста
                    // он может стать Replacer'ом, если, например, это пробел
                    char rc = Settings.GetChar(c);

                    if (!even) // Если это первый символ биграммы
                    {
                        // запоминаем и ищем второй
                        prev = rc;
                        even = true;
                    }
                    else
                    {
                        // Это второй символ биграммы
                        if (prev == rc) // и он такойже как и первый
                        {
                            if (prev != Settings.Replacer) // а первый не Replacer
                            {
                                // то вернем биграмму с Replacer в конце
                                yield return prev;
                                yield return Settings.Replacer;

                                // и будем считать, что уже нашли первый символ в следующей биграмме
                                prev = rc;
                            }
                        }
                        else
                        {
                            // Ну, а если они разные, то вернем оба и будем искать дальше
                            yield return prev;
                            yield return rc;
                            even = false;
                        }

                    }
                }

                // Если мы ищем второй символ, а строка закончилась, 
                // при этом первый символ не Replacer
                if (even && prev != Settings.Replacer)
                {
                    yield return prev;
                    yield return Settings.Replacer;
                }
            }

            /// <summary>
            /// Шифр Плейфера
            /// </summary>
            /// <param name="Text">Исходный текст</param>
            /// <param name="ModeCrypt">True если нужно зашифровать. False - расшифровать</param>
            public string Crypt(string Text, bool ModeCrypt = true)
            {
                int shift = ModeCrypt ? 1 : -1;
                StringBuilder sb = new StringBuilder();
                // Разбиваем на биграммы
                var chars = Bigrams(Text).GetEnumerator();
                while (chars.MoveNext())
                {
                    // Получаем координаты символов биграммы в таблице
                    // При расшифровке, если шифротекст неверен 
                    // т.е. имеет нечетную длину или неизвестные алфавиту символы
                    // вылетит исключение (поэтому лучше раздить на два метода: шифровки и дешифровки
                    // и перебрасывать исключение). Для шифровки такого не будет
                    var p1 = Positions[chars.Current];
                    chars.MoveNext();
                    var p2 = Positions[chars.Current];

                    // Если они на одной строке - переводим вправо
                    // Если в одной колнке - вниз
                    int error = 0;
                    if (p1.Column == p2.Column)
                    {
                        p1.Column = Mod(p1.Column + shift, Settings.Columns);
                        p2.Column = Mod(p2.Column + shift, Settings.Columns);
                        error++;
                    }
                    else if (p1.Row == p2.Row)
                    {
                        p1.Row = Mod(p1.Row + shift, Settings.Rows);
                        p2.Row = Mod(p2.Row + shift, Settings.Rows);
                        error++;
                    }

                    if (error == 2)
                        throw new ArgumentException("Неверные биграммы");

                    sb.Append(Matrix[p1.Row, p2.Column]);
                    sb.Append(Matrix[p2.Row, p1.Column]);
                }
                return sb.ToString();
            }

            private int Mod(int x, int m)
            {
                // остаток от деления для отрицательных чисел
                // для -1 вернет (m-1)
                return (x % m + m) % m;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Ключ: ");
                sb.AppendLine(Key);
                for (int r = 0; r < Settings.Rows; r++)
                {
                    for (int c = 0; c < Settings.Columns; c++)
                    {
                        sb.Append(Matrix[r, c]);
                        sb.Append(' ');
                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }

        }
        public class PlayFairRu56 : PlayFairSettings
        {
            public PlayFairRu56()
                : base()
            {
                Replaces.Add('ё', 'е');
                Replaces.Add('й', 'и');
                Replaces.Add('ъ', 'ь');
            }

            protected override char[] AlphabetChars { get { return "абвгдежзиклмнопрстуфхцчшщьыэюя".ToCharArray(); } }
            public override char Replacer { get { return 'х'; } }
            public override int Columns { get { return 5; } }
            public override int Rows { get { return 6; } }
        }



        //Шифровка
        private void mainbutton_Click(object sender, EventArgs e)
        {
            string key = textBox4.Text;
            if (key == string.Empty)
            {
                MessageBox.Show("Введите ключ!");
            }
            if (Pltextshif.Text == string.Empty)
            {
                MessageBox.Show("Введите текст!");
            }
            try
            {
                PlayFairSettings ps = new PlayFairRu56();
                PlayFair pf = new PlayFair(ps, key);
                Console.WriteLine(pf);

                string Text = Pltextshif.Text;
                string TextRs = string.Empty;

                int i = 0;
                foreach (char c in pf.Bigrams(Text))
                {
                    Console.Write(c);

                    i++;
                    if (i % 2 == 0) Console.Write(' ');
                    if (i % 10 == 0) Console.WriteLine();
                }

                Text = pf.Crypt(Text, true);
                Plresult.Text = Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Расшифровка
        private void buttonchik_Click(object sender, EventArgs e)
        {
            string key = textBox4.Text;
            if (key == string.Empty)
            {
                MessageBox.Show("Введите ключ!");
            }
            if (PlRash.Text == string.Empty)
            {
                MessageBox.Show("Введите текст!");
            }
            try
            {
                PlayFairSettings ps = new PlayFairRu56();
                PlayFair pf = new PlayFair(ps, key);
                Console.WriteLine(pf);

                string Text = PlRash.Text;
                string TextRs = string.Empty;

                int i = 0;
                foreach (char c in pf.Bigrams(Text))
                {
                    Console.Write(c);

                    i++;
                    if (i % 2 == 0) Console.Write(' ');
                    if (i % 10 == 0) Console.WriteLine();
                }
                Text = pf.Crypt(Text, false);
                textBox3.Text = Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            dritteundzweipanel.Visible = false;
            panel2.Visible = false;
            panelPlaefer.Visible = true;
        }

        private void exit_button_PL_Click(object sender, EventArgs e)
        {
            panelPlaefer.Visible = false;
            dritteundzweipanel.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;


        }

        private void buttex_Click(object sender, EventArgs e)
        {
            panelPlaefer.Visible = false;
            dritteundzweipanel.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void buex_Click(object sender, EventArgs e)
        {
            panelPlaefer.Visible = false;
            dritteundzweipanel.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
        }
        #endregion

        #region 4.1
        private void button9_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            string str = string.Empty;
            int[] arr = new int[6] { -3, 0, 6, 9, 12, 15 };
            int[] arr1 = new int[6] { -30, 10, 63, 59, 120, 175 };


            if (radioButton1.Checked)//от 3 до 12 целые
            {
                for (int i = 0; i < 10; i++)
                {
                    str += Convert.ToString(rand.Next(3, 12)) + " || ";
                }
                textBox8.Text = str;
                str = string.Empty;
            }

            if (radioButton2.Checked)//Из множества {–3, 0, 6, 9, 12, 15}.
            {
                for (int i = 0; i < 10; i++)
                {
                    str += Convert.ToString(arr[new Random().Next(0, arr.Length)]) + " || ";
                }
                textBox8.Text = str;
                str = string.Empty;
            }

            if (radioButton3.Checked)//От 3 до 12, вещественные
            {
                for (int i = 0; i < 10; i++)
                {
                    str += Convert.ToString(rand.Next(3, 12) / 10.0) + " || ";
                }
                textBox8.Text = str;
                str = string.Empty;
            }

            if (radioButton4.Checked)//От –2,3 до 10,7 с шагом 0,1.
            {
                double min = -2.3;
                double max = 10.3;
                double d = 0;
                string result = string.Empty;
                for (int i = 0; i < 10; i++)
                {
                    d = min + rand.NextDouble() * (max - min) + 0.1;
                    result += String.Format("{0:f1}", d) + " || ";
                }
                textBox8.Text = result;
                str = string.Empty;
            }

            if (radioButton5.Checked)//Из множества {–30; 10; 63; 59; 120; 175}
            {
                for (int i = 0; i < 10; i++)
                {
                    str += Convert.ToString(arr1[new Random().Next(0, arr1.Length)]) + " || ";
                }
                textBox8.Text = str;
                str = string.Empty;
            }

            if (radioButton6.Checked)//Из множества {1; 0,1; 0,01; …; 10–15}.
            {

                for (int i = 0; i < 10; i++)
                {
                    str += Convert.ToString(arr2[new Random().Next(0, arr2.Length)]) + " || ";
                }
                textBox8.Text = str;
                str = string.Empty;
            }
        }
        #endregion
        #region 4.2 Быки и коровы

        private void button12_Click(object sender, EventArgs e)
        {
            string userWord = userWordTextBox.Text;

            if (!IsValid(userWord))


            {
                return;
            }

            stepCount++;
            int bullsCount = CalculateBullsCount(userWord);
            int cowsCount = CalculateCowsCount(userWord);

            bullsCountlabel.Text =/* "Быков = " +*/ Convert.ToString(bullsCount);
            cowsCountlabel.Text = /*("Коров = " + */Convert.ToString(cowsCount);

            

            if (bullsCount == wordLength)
            {
                MessageBox.Show("Вы победили за " + stepCount + " ходa(ов)!!!");
                button12.Enabled = false;
            }
        }
        private bool IsValid(string userword)
        {
            if (userword.Length != wordLength)
            {
                MessageBox.Show("Строка должна быть длиной 4!");
                return false;
            }

            for (int i = 0; i < wordLength; i++)
            {
                if (!char.IsDigit(userword[i]))
                {
                    MessageBox.Show("Строка должна содержать только цифры!");
                    return false;
                }
            }

            for (int i = 0; i < userword.Length; i++)
            {
                for (int j = i + 1; j < userword.Length; j++)
                {
                    if (userword[i] == userword[j])
                    {
                        MessageBox.Show("Строка должна содержать уникальные цифры!");
                        return false;
                    }
                }
            }

            return true;
        }
        private int CalculateBullsCount(string userWord)
        {
            int bullsCount = 0;
            for (int i = 0; i < wordLength; i++)
            {
                if (PuzzleWord[i] == userWord[i])
                {
                    bullsCount++;
                }
            }
            return bullsCount;
        }

        private int CalculateCowsCount(string userWord)
        {
            int cowsCount = 0;
            for (int i = 0; i < wordLength; i++)
            {
                for (int j = 0; j < wordLength; j++)
                {
                    if (i == j)
                        continue;
                    if (PuzzleWord[i] == userWord[j])
                    {
                        cowsCount++;
                    }
                }
            }
            return cowsCount;
        }

        private void generationcowscode_Click(object sender, EventArgs e)
        {
            stepCount = 0;
            puzzleWordLabel.Text = "";
            PuzzleWord = string.Empty;
            List<int> digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            for (int i = 0; i < wordLength; i++)
            {
                int digitindex = random.Next(0, digits.Count);
                PuzzleWord += digits[digitindex].ToString();
                digits.RemoveAt(digitindex);
            }
            puzzleWordLabel.Text = PuzzleWord;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Правильный код: " + puzzleWordLabel.Text);
        }

        #endregion

        #region 5.1 Двойная перестановка

        class CharNum
        {

            private char _ch;

            private int _numberInWord;

            public char Ch
            {
                get { return _ch; }
                set
                {
                    if (_ch == value)
                        return;
                    _ch = value;
                }
            }

            public int NumberInWord
            {
                get { return _numberInWord; }
                set
                {
                    if (_numberInWord == value)
                        return;
                    _numberInWord = value;
                }
            }
        }
        public void Shifr(string firstKey, string secondKey, string stringUser)
        {
            //// Первый ключ, количество столбцов
            //string firstKey = ;
            ////// Второй ключ, количество строк
            //string secondKey =;
            ////// Предложение которое шифруем
            //string stringUser =; 



            // Матрица в которой производим шифрование
            char[,] matrix = new char[secondKey.Length, firstKey.Length];

            // Счетчик символов в строке
            int countSymbols = 0;

            // Переводим строки в массивы типа char
            char[] charsFirstKey = firstKey.ToCharArray();
            char[] charsSecondKey = secondKey.ToCharArray();
            char[] charStringUser = stringUser.ToCharArray();

            // Создаем списки в которых будут храниться символы и порядковы номера символов
            List<CharNum> listCharNumFirst =
                new List<CharNum>(firstKey.Length);

            List<CharNum> listCharNumSecond =
                new List<CharNum>(secondKey.Length);

            // Заполняем символами из ключей
            listCharNumFirst = FillListKey(charsFirstKey);
            listCharNumSecond = FillListKey(charsSecondKey);

            // Заполняем порядковыми номерами
            listCharNumFirst = FillingSerialsNumber(listCharNumFirst);
            listCharNumSecond = FillingSerialsNumber(listCharNumSecond);

            ShowKey(listCharNumFirst, "Первый ключ: ");
            ShowKey(listCharNumSecond, "Второй ключ: ");

            // Заполнение матрицы строкой пользователя

            int a = listCharNumFirst.Count + listCharNumSecond.Count;
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {

                    try
                    {
                        matrix[i, j] = charStringUser[countSymbols++];
                    }
                    catch (Exception)
                    {
                        for (int b = charStringUser.Length; b < a; b++)
                        {
                            matrix[i, j] += ' ';
                        }
                    }
                }
            }

            countSymbols = 0;
            // Заполнение матрицы с учетом шифрования. 
            // Переставляем столбцы по порядку следования в первом ключе. 
            // Затем переставляем строки по порядку следования во втором ключа. 
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    try
                    {
                        matrix[listCharNumSecond[i].NumberInWord,
                            listCharNumFirst[j].NumberInWord] = charStringUser[countSymbols++];
                    }
                    catch (Exception)
                    {
                        for (int b = charStringUser.Length; b < a; b++)
                        {
                            matrix[listCharNumSecond[i].NumberInWord,
                                listCharNumFirst[j].NumberInWord] += ' ';
                        }
                    }
                }
            }

            ShowMatrix(matrix, "Зашифрованное значение: ");
        }

        /// <summary>
        /// Возвращает порядковый номер символа по алфавиту.
        /// </summary>
        /// <param name="s">Символ, чей порядковый номер, необходимо узнать.</param>
        /// <returns></returns>
        public static int GetNumberInThealphabet(char s)
        {
            string str = @"АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";

            int number = str.IndexOf(s) / 2;

            return number;
        }

        /// <summary>
        /// Заполнение символами списка с ключом.
        /// </summary>
        /// <param name="chars">массив символов.</param>
        /// <returns>Список символов.</returns>
        static List<CharNum> FillListKey(char[] chars)
        {
            List<CharNum> listKey = new List<CharNum>(chars.Length);

            for (int i = 0; i < chars.Length; i++)
            {
                CharNum charNum = new CharNum()
                {
                    Ch = chars[i],
                    NumberInWord = GetNumberInThealphabet(chars[i])
                };

                listKey.Add(charNum);
            }
            return listKey;
        }
        /// <summary>
        /// Отображение ключа.
        /// </summary>
        /// <param name="listCharNum">Список в котором содержатся символы с порядковыми номерами.</param>
        static void ShowKey(List<CharNum> listCharNum, string message)
        {
            Console.WriteLine(message);

            foreach (var i in listCharNum)
            {
                Console.Write(i.Ch + " ");
            }
            Console.WriteLine();

            foreach (var i in listCharNum)
            {
                Console.Write(i.NumberInWord + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Заполнение символов ключей, порядковыми номерами.
        /// </summary>
        /// <param name="listCharNum"></param>
        /// <returns></returns>
        static List<CharNum> FillingSerialsNumber(
            List<CharNum> listCharNum)
        {
            int count = 0;

            var result = listCharNum.OrderBy(a =>
                a.NumberInWord);

            foreach (var i in result)
            {
                i.NumberInWord = count++;
            }

            return listCharNum;
        }
        /// <summary>
        /// Отображение матрицы.
        /// </summary>
        /// <param name="matrix">Матрица с символами.</param>

        public void ShowMatrix(char[,] matrix, string message)
        {
            string result = string.Empty;
            Console.WriteLine(message);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += Convert.ToString(matrix[i, j]);
                }
            }
            zwtextrs.Text = result;
            Console.WriteLine();
            Console.WriteLine();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Shifr(klv_colm.Text, klv_rows.Text, zwtextsh.Text);
        }


        #endregion
        #region 5.2 Полибий 1.2.3


        public enum Method { Method1, Method2 }

        class PolybiusSquare
        {
            char[,] square;
            string alphabet;
            Method encryptMethod;

            public PolybiusSquare(string alphabet = null, Method cipherMethod = Method.Method1)
            {
                this.alphabet = alphabet ?? "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ ";
                encryptMethod = cipherMethod;
            }

            //возвращает квадрат Полибия
            char[,] GetSquare(string key)
            {
                var newAlphabet = alphabet;
                //удаляем из алфавита все символы которые содержит ключ
                for (int i = 0; i < key.Length; i++)
                {
                    newAlphabet = newAlphabet.Replace(key[i].ToString(), "");
                }

                //добавляем пароль в начало алфавита, а в конец дополнительные знаки
                //для того чтобы избежать пустых ячеек
                newAlphabet = key + newAlphabet + "0123456789!@#$%^&*)_+-=<>?,.";

                //получаем размер стороны квадрата
                //округлением квадратного корня в сторону большего целого числа
                var n = (int)Math.Ceiling(Math.Sqrt(alphabet.Length));

                //создаем и заполняем массив
                square = new char[n, n];
                var index = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (index < newAlphabet.Length)
                        {
                            square[i, j] = newAlphabet[index];
                            index++;
                        }
                    }
                }

                return square;
            }

            //поиск символа в двухмерном массиве
            bool FindSymbol(char[,] symbolsTable, char symbol, out int column, out int row)
            {
                var l = symbolsTable.GetUpperBound(0) + 1;
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if (symbolsTable[i, j] == symbol)
                        {
                            //значение найдено
                            row = i;
                            column = j;
                            return true;
                        }
                    }
                }

                //если ничего не нашли
                row = -1;
                column = -1;
                return false;
            }

            public string PolibiusEncrypt(string text, string password, int method)
            {
                var outputText = "";
                var square = GetSquare(password);
                switch (method)
                {
                    case 1:
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                var newRowIndex = rowIndex == square.GetUpperBound(1)
                                    ? 0
                                    : rowIndex + 1;
                                outputText += square[newRowIndex, columnIndex].ToString();
                            }
                        }
                        break;

                    case 2:
                        var m = text.Length;
                        var coordinates = new int[m * 2];
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                coordinates[i] = columnIndex;
                                coordinates[i + m] = rowIndex;
                            }
                        }

                        for (int i = 0; i < m * 2; i += 2)
                        {
                            outputText += square[coordinates[i + 1], coordinates[i]];
                        }
                        break;

                    case 3:
                        var l = text.Length;
                        var coordinate = new int[l * 2];

                        for (int i = 0; i < l; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                coordinate[i + l] = columnIndex;
                                coordinate[i] = rowIndex;
                            }
                        }

                        coordinate.Skip(1).Concat(coordinate.Take(1));

                        for (int i = 0; i < l * 2; i += 2)
                        {
                            outputText += square[coordinate[i], coordinate[i + 1]];
                        }
                        break;

                       
                }

                return outputText;
            }

            public string PolybiusDecrypt(string text, string password, int method)
            {
                var outputText = "";
                var square = GetSquare(password);
                var m = text.Length;
                switch (method)
                {
                    case 1:
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                var newRowIndex = rowIndex == 0
                                    ? square.GetUpperBound(1)
                                    : rowIndex - 1;
                                outputText += square[newRowIndex, columnIndex].ToString();
                            }
                        }
                        break;

                    case 2:
                        var coordinates = new int[m * 2];
                        var j = 0;
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                coordinates[j] = columnIndex;
                                coordinates[j + 1] = rowIndex;
                                j += 2;
                            }
                        }

                        for (int i = 0; i < m; i++)
                        {
                            outputText += square[coordinates[i + m], coordinates[i]];
                        }
                        break;

                    case 3:
                        var coordinate = new int[m * 2];
                        var l = 0;
                        for (int i = 0; i < m; i++)
                        {
                            if (FindSymbol(square, text[i], out int columnIndex, out int rowIndex))
                            {
                                coordinate[l + 1] = columnIndex;
                                coordinate[l] = rowIndex;
                                l += 2;
                            }
                        }
                        coordinate.Skip(1).Concat(coordinate.Take(1));

                        for (int i = 0; i < m; i++)
                        {
                            outputText += square[coordinate[i], coordinate[i + m]];
                        }
                        break;
                }

                return outputText;
            }
        }



        private void button7_Click(object sender, EventArgs e)//метод 1 шифр
        {
            var polybius = new PolybiusSquare();
            var message = pm1text.Text.ToUpper();
            var pass = string.Empty;
            var cipherText = polybius.PolibiusEncrypt(message, pass, 1);
            pm1res.Text = cipherText;
        }

        private void button11_Click(object sender, EventArgs e)//метод 1 расшифр
        {
            var polybius = new PolybiusSquare();
            var message = pm1text.Text.ToUpper();
            var pass = string.Empty;
            var cipherText = polybius.PolybiusDecrypt(message, pass, 1);
            pm1res.Text = cipherText;
        }

        private void button20_Click(object sender, EventArgs e)//метод2 шифр
        {
            var polybius = new PolybiusSquare();
            var message = textBox6.Text.ToUpper();
            var pass = string.Empty;
            var cipherText = polybius.PolibiusEncrypt(message, pass, 2);
            textBox7.Text = cipherText;
        }

        private void button19_Click(object sender, EventArgs e)//метод 2 расшифр
        {
            var polybius = new PolybiusSquare();
            var message = textBox6.Text.ToUpper();
            var pass = string.Empty;
            var cipherText = polybius.PolybiusDecrypt(message, pass, 2);
            textBox7.Text = cipherText;
        }
        bool IsDigitsOnly(string str) //проверка на нахождение чисел в ключ слове
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void pm3shif_Click(object sender, EventArgs e)//метод 3 шифр
        {
            if(keywordpolibus.Text == string.Empty)//проверка на отсутствие ключ слова
            {
                MessageBox.Show("Введите ключ слово!");
            }
            if (IsDigitsOnly(keywordpolibus.Text))
            {
                MessageBox.Show("Ключ-слово не может содержать в себе цифры!");
            }
            else
            {
                var polybius = new PolybiusSquare();
                var message = pm3text.Text.ToUpper();
                var pass = keywordpolibus.Text;
                var cipherText = polybius.PolibiusEncrypt(message, pass, 3);
                pm3res.Text = cipherText;
            }
        }
        private void pm3ras_Click(object sender, EventArgs e)//метод 3 расшифр
        {
            if (keywordpolibus.Text == string.Empty)
            {
                MessageBox.Show("Введите ключ слово!");
            }
            if (IsDigitsOnly(keywordpolibus.Text))
            {
                MessageBox.Show("Ключ-слово не может содержать в себе цифры!");
            }
            else
            {
                var polybius = new PolybiusSquare();
                var message = pm3text.Text.ToUpper();
                var pass = keywordpolibus.Text;
                var cipherText = polybius.PolybiusDecrypt(message, pass, 3);
                pm3res.Text = cipherText;
            }
        }

        #endregion

        #region Кнопки
        private void button14_Click(object sender, EventArgs e)
        {
            mainFunf.Visible = false;
            pn5_1.Visible = true;
            pn5_123.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mainFunf.Visible = false;
            pn5_1.Visible = false;
            pn5_123.Visible = true;
        }


        private void back_to5_Click(object sender, EventArgs e)
        {
            mainFunf.Visible = true;
            pn5_1.Visible = false;
            pn5_123.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            mainFunf.Visible = true;
            pn5_1.Visible = false;
            pn5_123.Visible = false;
        }

        private void cowsbackbut_Click(object sender, EventArgs e)
        {
            cowsgame.Visible = true;
            panel4main.Visible = false;
            panel4_1zd.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel4main.Visible = false;
            panel4_1zd.Visible = true;
            cowsgame.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cowsgame.Visible = false;
            panel4main.Visible = true;
            panel4_1zd.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel4_1zd.Visible = false;
            cowsgame.Visible = false;
            panel4main.Visible = true;
        }
        #endregion

        #region 6.1 RSA
        string way = @"C:\Users\JoySail\source\repos\LabApp\labapp\res\out1.txt";//путь до файла!!!ПОМЕНЯТЬ!!!

        char[] characters = new char[] { '#','А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                         'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                         'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                         'Э', 'Ю', 'Я', 'A','B','C','D','E','F','G','H','I','J',
                                         'K','L','M','N','O','P','Q','R','S','T','U','V','W','X'
                                         ,'Y','Z',' ', '1', '2', '3', '4', '5', '6', '7',
                                         '8', '9', '0' };

        private void button4_Click(object sender, EventArgs e)//шифрование RSA ||res_textBox13
        {
            if ((Pkeytext.Text.Length > 0) && (Qkeytext.Text.Length > 0))
            {
                long p = Convert.ToInt64(Pkeytext.Text);
                long q = Convert.ToInt64(Qkeytext.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string s = "";
                    s = textBox13.Text.ToUpper();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);



                    List<string> result = RSA_Endoce(s, e_, n);


                    StreamWriter sw = new StreamWriter(way);
                    foreach (string item in result)
                        sw.WriteLine(item);
                    sw.Close();


                    foreach (string item in result)
                        textBox9.Text += item;


                    
                    Dkeytext.Text = e_.ToString();
                    Nkeytext.Text = n.ToString();
                    textBox11.Text = n.ToString();

                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void button21_Click(object sender, EventArgs e)//дешифрование RSA ||res_textBox14
        {
            if ((Dkeytext.Text.Length > 0) && (Nkeytext.Text.Length > 0))
            {
                long d = Convert.ToInt64(Dkeytext.Text);
                long n = Convert.ToInt64(Nkeytext.Text);

                List<string> input = new List<string>();
                
                StreamReader sr = new StreamReader(way);

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());
                }

                sr.Close();

                string result = RSA_Dedoce(input, d, n);

                textBox14.Text = result;

            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;
            
            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }   

            return result;
        }
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }
        private long Calculate_e(long d, long m)
        {
            long e = 3;//Int64.Parse(Eexp.Text);
            
            
            while (true)
            {
                if ((e * d) % m == 1)
                        break;
                    else
                        e++;
                }
             return e;

        }
        //Кнопки перехода с мэйна 6 на задания
        
        private void buttonchikinazad61_Click(object sender, EventArgs e)
        {
            RSApanel.Visible = false;
            mainpanel6.Visible = true;
            elgamalpanel.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            RSApanel.Visible = true;
            mainpanel6.Visible = false;
            elgamalpanel.Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            elgamalpanel.Visible = true;
            RSApanel.Visible = false;
            mainpanel6.Visible = false;
        }

        #endregion
        #region 6.2 Эль-Гамаль

        private int Rand()//Ф-я получения случайного числа
        {
            Random random = new Random();
            return random.Next();
        }
        int power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }
        int mul(int a, int b, int n) // a*b mod n - умножение a на b по модулю n
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
        void crypt(int p, int g, int x, string strIn)
        {
            txtBCrypt.Text = "";
            int y = power(g, x, p);
            if (strIn.Length > 0)
            {
                char[] temp = new char[strIn.Length - 1];
                temp = strIn.ToCharArray();
                for (int i = 0; i <= strIn.Length - 1; i++)
                {
                    int m = (int)temp[i];
                    if (m > 0)
                    {
                        int k = Rand() % (p - 2) + 1; // 1 < k < (p-1)
                        int a = power(g, k, p);
                        int b = mul(power(y, k, p), m, p);
                        txtBCrypt.Text = txtBCrypt.Text + a + " " + b + " ";
                    }
                }
            }
        }
        void decrypt(int p, int x, string strIn)
        {
            if (strIn.Length > 0)
            {
                txtBDecrypt.Text = "";
                string[] strA = strIn.Split(' ');
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0;
                        int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            ai = ai * 10 + (int)(a[j] - 48);
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (int)(b[j] - 48);
                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            int deM = mul(bi, power(ai, p - 1 - x, p), p);// m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p - с формулой небольшие проблемы и она не самая точная
                            char m = (char)deM;
                            txtBDecrypt.Text = txtBDecrypt.Text + m;
                        }
                    }
                }

            }
        }
        private void ElGamalCrypt_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(593);
            int g = Convert.ToInt32(123);
            int x = Convert.ToInt32(8);
            crypt(p, g, x, txtBIn.Text);
        }

        private void ElGamalDecrypt_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(593);
            int g = Convert.ToInt32(123);
            int x = Convert.ToInt32(8);
            decrypt(p, x, txtBCrypt.Text);
        }

        private void ElGamalInfo_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(593);
            int g = Convert.ToInt32(123);
            int x = Convert.ToInt32(8);
            MessageBox.Show("P = " + p + ": G = " + g + ": X = " + x);
        }


        private void button24_Click(object sender, EventArgs e)//back button
        {
            elgamalpanel.Visible = false;
            RSApanel.Visible = false;
            mainpanel6.Visible = true;
        }
        #endregion

        #region 7.1 Алгоритм Диффи-Хеллмана

        Random rand = new Random();

        long p, g, a, b, A, B, s;

        private void button22_Click_1(object sender, EventArgs e)
        {
            if ((Pkeybox.Text.Length > 0) && (Gkeybox.Text.Length > 0))
            {
                p = int.Parse(Pkeybox.Text);
                g = int.Parse(Gkeybox.Text);
                if (IsTheNumberSimple(p) && IsTheNumberSimple(g))
                {
                    if (p > g)
                    {
                        a = rand.Next(1, 100);
                        b = rand.Next(1, 100);
                        abox.Text = a.ToString();
                        bbox.Text = b.ToString();
                        A = Calculate(g, a, p);
                        B = Calculate(g, b, p);
                        Akeybox.Text = A.ToString();
                        Bkeybox.Text = B.ToString();
                    }
                    else
                    {
                        MessageBox.Show("G больше либо равно P!");
                    }
                }
                else
                    MessageBox.Show("P или G - не простые числа!");
                
            }
            else
                MessageBox.Show("Введите P и G!");
        }

        private void button23_Click(object sender, EventArgs e)//результат S Алисы
        {
            s = Calculate(B, a, p);
            AliceresS.Text = s.ToString();
            s = 0;
        }

        private void button25_Click(object sender, EventArgs e)//результат S Боба
        {
            s = Calculate(A, b, p);
            BobresS.Text = s.ToString();
            s = 0;
        }


        private long Calculate(long a, long b, long n)// a^b mod n
        {
            long tmp = a;
            long sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }

        #endregion
        #region 7.2 Хеширование

        public string CreateMD5(string input)
        {
            
            using (MD5 md5 = MD5.Create())//MD5 - способ хеширования. В данном случае MD5 - метод библиотеки Security.Cryptography;
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input); //переводим нашу строку в кодировку юникода (UTF8) и получаем байты нашей строки
                byte[] hashBytes = md5.ComputeHash(inputBytes); //само хеширование (приравниваем новый байтовский массив к результатам хеширования байтовского массива выше)

                // Переводим нашу строку в байтовский массив (16ричная строка)
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++) //цикл от длинны массива. собственно сам цикл хеширования
                {
                    sb.Append(hashBytes[i].ToString("x2")); //добавляем результат каждой перенной в массив hashBytes. передаем в формате string x2 для печати в шестнадцатиричном формате маленькими буквами
                }
                return sb.ToString();//возвращаем значение
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox12.Text = CreateMD5(textBox10.Text);//обращаемся к методу CreateMD5, грузим в input содержимое текс бокса
        }
        #endregion
        #region Кнопки 7
        private void backtoLr7_Click(object sender, EventArgs e)
        {
            DHpanel.Visible = false;
            lr7main.Visible = true;
            Haschpanel.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DHpanel.Visible = false;
            lr7main.Visible = true;
            Haschpanel.Visible = false;
        }

        private void Haschbutton_Click(object sender, EventArgs e)
        {
            DHpanel.Visible = false;
            lr7main.Visible = false;
            Haschpanel.Visible = true;
        }

        private void DHbutton_Click(object sender, EventArgs e)
        {
            DHpanel.Visible = true;
            lr7main.Visible = false;
            Haschpanel.Visible = false;
        }

        #endregion

        #region 9 Методы нахождения

        int k1, s1, m, v, n2, t2, s2, k3, t3, s3;

        double n1;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void k1text_TextChanged(object sender, EventArgs e)
        {

        }

        private void s1text_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelmainzw_Paint(object sender, PaintEventArgs e)
        {

        }



        //ниже я как додик объявил переменные но удобно и легко в понимании \/
        private void variant13_CheckedChanged(object sender, EventArgs e)
        {
            //1
            n1 = 77; n1text.Text = n1.ToString();
            k1 = 11; k1text.Text = k1.ToString();
            s1 = 20; s1text.Text = s1.ToString();
            m = 0; m1text.Text = m.ToString();
            v = 0; v1text.Text = v.ToString();
            //2
            n2 = 74; n2text.Text = n2.ToString();
            t2 = 100; t2text.Text = t2.ToString();
            s2 = 15; s2text.Text = s2.ToString();
            //3
            k3 = 10; k3text.Text = k3.ToString();
            t3 = 80; t3text.Text = t3.ToString();
            s3 = 30; s3text.Text = s3.ToString();
        }
        private void variant11_CheckedChanged(object sender, EventArgs e)
        {
            //1
            n1 = 33; n1text.Text = n1.ToString();
            k1 = 15; k1text.Text = k1.ToString();
            s1 = 30; s1text.Text = s1.ToString();
            m = 0; m1text.Text = m.ToString();
            v = 0; v1text.Text = v.ToString();
            //2
            n2 = 45; n2text.Text = n2.ToString();
            t2 = 50; t2text.Text = t2.ToString();
            s2 = 30; s2text.Text = s2.ToString();
            //3
            k3 = 6; k3text.Text = k3.ToString();
            t3 = 90; t3text.Text = t3.ToString();
            s3 = 100; s3text.Text = s3.ToString();

        }
        private void variant3_CheckedChanged(object sender, EventArgs e)
        {
            //1
            n1 = 52; n1text.Text = n1.ToString();
            k1 = 6; k1text.Text = k1.ToString();
            s1 = 30; s1text.Text = s1.ToString();
            m = 5; m1text.Text = m.ToString();
            v = 10; v1text.Text = v.ToString();
            //2
            n2 = 52; n2text.Text = n2.ToString();
            t2 = 60; t2text.Text = t2.ToString();
            s2 = 30; s2text.Text = s2.ToString();
            //3
            k3 = 10; k3text.Text = k3.ToString();
            t3 = 60; t3text.Text = t3.ToString();
            s3 = 30; s3text.Text = s3.ToString();
        }
        //
        

        //1
        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(n1text.Text) < 0 || int.Parse(k1text.Text) < 0 || int.Parse(s1text.Text) < 0 || int.Parse(m1text.Text) < 0 || int.Parse(v1text.Text) < 0)
                {
                    MessageBox.Show("Переменные не могут быть отрицательными!");
                }
                else
                {
                    double n = Convert.ToDouble(n1text.Text);
                    int k = Convert.ToInt32(k1text.Text);
                    int s = Convert.ToInt32(s1text.Text);
                    int m = Convert.ToInt32(m1text.Text);
                    int v = Convert.ToInt32(v1text.Text);
                    double C;
                    double t;
                    double T;
                    double Ti;
                    C = Math.Pow(n, k);
                    t = Math.Ceiling(C / s);
                    if (v == 0 && m==0)
                    {
                        T = t;
                    }
                    else if(v!=0 && m==0)
                    {                        
                        T = t;
                    }
                    else 
                    {
                        T = (t * v / m);
                    }
                    
                    if (variant6.Checked)
                    {
                        Ti = Convert.ToInt64(((((t + T) / 60) / 60) / 24) / 365);
                        result1text.Text = "Итог: " + Ti.ToString() + " лет";
                    }
                    if (variant8.Checked)
                    {
                        Ti = Convert.ToInt64(((t + T) / 60) / 60);
                        result1text.Text = "Итог: " + Ti.ToString() + " часов";
                    }
                    if (variant12.Checked)
                    {
                        Ti = Convert.ToInt64(((((t + T) / 60) / 60) / 24) / 365);
                        result1text.Text = "Итог: " + Ti.ToString() + " год";
                    }

                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели значения, либо значения некорректны!");
            }
            
        }

        //2
        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(n2text.Text) < 0 || int.Parse(s2text.Text) < 0 || double.Parse(t2text.Text) < 0)
                {
                    MessageBox.Show("Переменные не могут быть отрицательными!");
                }
                else
                {
                    double n = Convert.ToDouble(n2text.Text);
                    int s = Convert.ToInt32(s2text.Text);
                    double t = Convert.ToDouble(t2text.Text);
                    double k;
                    double C;
                    double l;
                    C = t * 365 * 24 * 60 * 60; //высчитываем кол-во вариантов
                    l = C * s;
                    k = Math.Ceiling(Math.Log(l, n)); //формула длинны пароля ищем кол-во символов
                    result2text.Text = "Длинна пароля: " + k.ToString() + " символов";

                }

            }
            catch
            {
                MessageBox.Show("Вы не ввели значения, либо значения некорректны!");
            }
        }

        //3
        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(k3text.Text) < 0 || int.Parse(s3text.Text) < 0 || double.Parse(t3text.Text) < 0)
                {
                    MessageBox.Show("Переменные не могут быть отрицательными!");
                }
                else
                {
                    double k = Convert.ToDouble(k3text.Text);
                    int s = Convert.ToInt32(s3text.Text);
                    double t = Convert.ToDouble(t3text.Text);
                    string n;
                    BigInteger f = new BigInteger(t * 365);
                    f = f * 24;
                    f = f * 60;
                    f = f * 60;
                    f = f * s;
                    n = Math.Ceiling(Math.Pow((Int64)f, 1.0 / k)).ToString();
                    result3text.Text = "Количество символов алфавита: " + n;
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели значения, либо значения некорректны!");

            }

        }
        #endregion
        #region 10.1 ЭЦП

        byte[] h = null;
        long pp, qq, nn, mm, dd, ee_;
        long[] storage = new long[16];//массив первого преобразования нашего хеша
        long[] result = new long[16];//массив второго преобразования нашего хеша
        private void button33_Click(object sender, EventArgs e)//получение ключей, проверки ключей, вычисление необходимых ключей
        {
            try
            {
                if (IsTheNumberSimple(Convert.ToInt64(ptextkey.Text)) && IsTheNumberSimple(Convert.ToInt64(qtextkey.Text)))
                {
                    pp = Convert.ToInt64(ptextkey.Text);
                    qq = Convert.ToInt64(qtextkey.Text);
                    nn = pp * qq;
                    mm = (pp - 1) * (qq - 1);
                    dd = Calculate_d(mm);
                    ee_ = Calculate_e(dd, mm);
                    dtextkey.Text = ee_.ToString();
                    ntextkey.Text = nn.ToString();
                }
                else
                {
                    MessageBox.Show("Введенные вами ключи не являются простыми!");
                }
            }
            catch
            {
                MessageBox.Show("Введите ключи (простые числа)!");
            }
        }

        private void button31_Click(object sender, EventArgs e)//хеширование нашего сообщения
        {
            if (textBox15.Text != string.Empty)
                textBox16.Text = CreateMD5(textBox15.Text);//хешируем через метод CreateMD5 реализованный в задании 7.2 хеширование
            else
                MessageBox.Show("Введите исходное сообщение!");
        }

        private void button32_Click(object sender, EventArgs e)//вычисление ЭЦП 
        {
            h = Saver(h);//приравняли наш байтовый массив h к значениям вычисления хеша через CreateMD5 нашего исходного сообщения (T)

            //взять !байтовый массив! и поэлементно его вычислять, после вновь занести полученные значения в массив и вывести его путем хеша. полученный хеш уже обрабатывать путем идей 2

            /*
                здесь происходит загрузка значений массива байтов хеша h в массив чисел(long) storage для дальнейших вычислений
                по формуле S = h^d mod n где S = результат, h - наш хеш(который я беру побайтово, по этому операции идут через массив c циклом)
                d = закрытый и открытый ключ(они у меня одинаковые:)) ), n = результат умножения p ключа на q ключ, в том числе и одна из частей ключа
             */
            for (int i = 0; i < h.Length; i++)
            { 
                storage[i] = Convert.ToInt64(h[i]);
                storage[i] = Calculate(storage[i], ee_, nn); //вычисление по вышеописанной формуле через метод Calculate - Метод Диффи-Хельмана(местонахождение)
                h[i] = Convert.ToByte((byte)storage[i]);
            }
            using (MD5 md5 = MD5.Create()) //хешируем наши новые данные
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < h.Length; i++)
                {
                    sb.Append(h[i].ToString("x2")); 
                }
                textBox17.Text = sb.ToString();
                textBox18.Text = sb.ToString();
            }
            h = null;
        }

        private void button34_Click(object sender, EventArgs e)//получение результата  обратная формула той,что выше^
        {

            h = Saver(h);
            for (int i = 0; i < h.Length; i++)
            {
                result[i] = Convert.ToInt64(storage[i]);
                result[i] = Calculate(storage[i], ee_, nn);
                h[i] = Convert.ToByte((byte)result[i]);
            }
            using (MD5 md5 = MD5.Create())
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < h.Length; i++)
                {
                    sb.Append(h[i].ToString("x2")); 
                }
                textBox19.Text = sb.ToString();
            }
            h = null;
        }

        public byte[] Saver(byte[] saver)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(textBox15.Text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                saver = hashBytes;
                return saver;
            }
        }
        //:)
        #endregion
    }
}
