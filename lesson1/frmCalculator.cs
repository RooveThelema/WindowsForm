using System.Globalization;

namespace lesson1
{
    public partial class Calculator : Form
    {
        char[] notSetSign = { '+', '-', '*', '/' };

        public Calculator()
        {
            InitializeComponent();
            plus.Click += btnNumberAction_Click;
            minus.Click += btnNumberAction_Click;
            button14.Click += btnNumberAction_Click;
            button13.Click += btnNumberAction_Click;
            equals.Click += btnRead;
            button16.Click += btnBackspace;
            button17.Click += btnClearEntry;
            button19.Click += btnChangeNumber;
            button21.Click += btnChangeNumber;
            button22.Click += btnChangeNumber;
            button23.Click += btnChangeNumber;
        }
        private void btnNumberAction_Click(object sender, EventArgs e)
        {
            //операции в целом + знаки для растановки и буфер мини
            var btn = (Button)sender;
            char smbl = btn.Text[0];

            string display = txtDisplay.Text;
            //-1 нет, другое есть
            int lastSmblIndex = display.LastIndexOfAny(notSetSign);

            //если нажали знак из массива
            if (Array.IndexOf(notSetSign, smbl) >= 0)
            {
                //скипаем если там пусто или стоит знак запятой
                if (display.Length == 0 || display.EndsWith(","))
                {
                    return;
                }


                //если стоит знк меняем его(не когда стоит цифра)
                if (lastSmblIndex == display.Length - 1)
                {
                    display = display.Substring(0, display.Length - 1);
                }
            }
            //дабы запятая не ставилась после знака
            else if (smbl == ',' && lastSmblIndex >= 0 && lastSmblIndex == display.Length - 1)
            {
                return;
            }
            //yе ставим вторую запятую в одном числе
            else if (smbl == ',' && display.IndexOf(',', lastSmblIndex + 1) >= 0)
            {
                return;
            }

            txtDisplay.Text = display + smbl;
        }

        //для счета всего что перед равно
        private void btnRead(object? sender, EventArgs e)
        {
            decimal? result = Calculate(txtDisplay.Text);
            if (result == null)
                return;

            txtDisplay.Text = result.Value.ToString(CultureInfo.GetCultureInfo("ru-RU"));
        }

        //cчитаем выражение с экрана.
        private decimal? Calculate(string display)
        {
            //убираем пробелы по краям
            display = display.Trim();
            decimal sum = 0;
            decimal currentTerm = 0;
            char operation = '+'; //первое число считаем как +число

            while (display.Length > 0)
            {
                //берём число до следующего знака или до конца строки
                int index = display.IndexOfAny(notSetSign, 1);
                if (index == -1)
                    index = display.Length;

                string text = display.Substring(0, index);
                decimal number = decimal.Parse(text, CultureInfo.GetCultureInfo("ru-RU"));

                if (operation == '/' && number == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return null;
                }

                //умножение и деление меняют только текущее слагаемое
                if (operation == '*')
                    currentTerm *= number;
                else if (operation == '/')
                    currentTerm /= number;
                else
                {
                    sum += currentTerm;
                    currentTerm = number;
                    if (operation == '-')
                        currentTerm = -number;
                }

                if (index == display.Length)
                    return sum + currentTerm;

                //запоминаем знак и оставляем текст после него
                operation = display[index];
                display = display.Substring(index + 1).TrimStart();
            }

            return null;
        }

        private int CurrentNumberStart(string display)
        {
            int start = display.Length;
            while (start > 0 && (char.IsDigit(display[start - 1]) || display[start - 1] == ','))
                start--;

            //минус после знака операции для числа
            if (start > 0 && display[start - 1] == '-')
            {
                string beforeMinus = display.Substring(0, start - 1).TrimEnd();
                if (beforeMinus.Length == 0 || "+-*/".Contains(beforeMinus[beforeMinus.Length - 1]))
                    start--;
            }
            return start;
        }

        private void btnBackspace(object? sender, EventArgs e)
        {
            string display = txtDisplay.Text;
            if (display.Length > 0)
                txtDisplay.Text = display.Substring(0, display.Length - 1);
        }

        private void btnClearEntry(object? sender, EventArgs e)
        {
            string display = txtDisplay.Text.TrimEnd();
            txtDisplay.Text = display.Substring(0, CurrentNumberStart(display));
        }

        private void btnChangeNumber(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            string display = txtDisplay.Text.TrimEnd();
            int start = CurrentNumberStart(display);
            string prefix = display.Substring(0, start);
            string entry = display.Substring(start);
            var culture = CultureInfo.GetCultureInfo("ru-RU");
            if (!decimal.TryParse(entry, culture, out decimal number))
                return;

            switch (button.Text)
            {
                case "±":
                    if (entry.StartsWith("-"))
                        entry = entry.Substring(1);
                    else
                        entry = "-" + entry;
                    txtDisplay.Text = prefix + entry;
                    return;
                case "1/x":
                    if (number == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя.");
                        return;
                    }
                    number = 1 / number;
                    break;
                case "✓":
                    if (number < 0)
                    {
                        MessageBox.Show("Для квадратного корня нужно неотрицательное число.");
                        return;
                    }
                    number = (decimal)Math.Sqrt((double)number);
                    break;
                case "%":
                    number /= 100;
                    //после + или берём процент от суммы слева.
                    string left = prefix.TrimEnd();
                    if (!left.EndsWith("+") && !left.EndsWith("-"))
                        break;

                    decimal? total = Calculate(left.Substring(0, left.Length - 1));
                    if (total == null)
                        return;
                    number *= total.Value;
                    break;
            }
            txtDisplay.Text = prefix + number.ToString(culture);
        }

        private void btnNumberActionClear(object sender, EventArgs e)
        {
            txtDisplay.Text = String.Empty;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
