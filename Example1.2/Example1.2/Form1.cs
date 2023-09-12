namespace Example1._2
{
    public partial class Form1 : Form
    {

        /// <summary>
        /// Родительский класс
        /// </summary>
        protected class Found
        {
            //fields
            protected string name;
            protected int credit;
            static protected int count;
            const string NL = "\r\n";
            //Constructors
            public Found()
            {
                name = "Nemo";
                credit = 0;
                count++;
            }
            public Found(string name, int credit)
            {
                this.name = name;
                this.credit = credit;
                count++;
            }
            public override string ToString()
            {
                string s = "Поля: name = {0}, credit = {1}";
                return String.Format(s, name, credit);
            }
            public string NonVirtualMethod()
            {
                return "Found: " + this.ToString();
            }
            public virtual string VirtualMethod()
            {
                return "Found: " + this.ToString();
            }
            public string Parse()
            {
                return "Выполнен разбор кода!";
            }
            public string Job()
            {
                string res = "";
                res += "VirtMethod: " + VirtualMethod() + NL;
                res += "NonVirtMethod: " + NonVirtualMethod() + NL;
                res += "Parse: " + Parse() + NL;
                return res;
            }
            public static string NumberOfObjects()
            {
                return "Объектов создано: " + count;
            }

        }


        protected class Derived : Found
        {
            //добавление и скрытие полей
            protected double debit;
            new protected double credit;
            //Конструкторы
            public Derived() : base()
            {
                debit = 0; credit = 0;
            }
            public Derived(string name, double debit,
                double credit) : base(name, (int)credit)
            {
                this.debit = debit;
                this.credit = credit;
            }
            //Методы
            public string MyBaseCredit()
            {
                return base.credit.ToString();
            }
            new public string Parse()
            {
                string res = base.Parse();
                res += "Выполнена проверка кода!";
                return res;
            }
            public override string ToString()
            {
                string s = "Поля: name = {0}, Basecredit = {1}" + "credit = {2}, debit = {3}";
                return String.Format(s, name, base.credit, credit, debit);
            }
            public override string VirtualMethod()
            {
                return "Derived: " + this.ToString();
            }
        }


        Found found;
        Derived derived;


        public Form1()
        {
            InitializeComponent();
            found = new Found();
            derived = new Derived();
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            string name = nameEditForFound.Text;
            int credit = 0;
            try
            {
                credit = int.Parse(creditEditForFound.Text);
                if (name != "")
                    found = new Found(name, credit);
                resultTextForFound.Text = "Объект класса Found успешно создан!";
            }
            catch (Exception)
            {
                resultTextForFound.Text = "Некорректно заданы числовые данные!";
            }
        }

        private void virtualMethodButtonForFound_Click(object sender, EventArgs e)
        {
            string res = found.VirtualMethod();
            resultTextForFound.Text = res;
        }

        private void nonVirtualMethodButtonForFound_Click(object sender, EventArgs e)
        {
            string res = found.NonVirtualMethod();
            resultTextForFound.Text = res;
        }

        private void toStringButtonForFound_Click(object sender, EventArgs e)
        {
            string res = found.ToString();
            resultTextForFound.Text = res;
        }

        private void ParseButtonForFound_Click(object sender, EventArgs e)
        {
            string res = found.Parse();
            resultTextForFound.Text = res;
        }

        private void jobButtonForFound_Click(object sender, EventArgs e)
        {
            string res = found.Job();
            resultTextForFound.Text = res;
        }

        private void numberOfObjectButtonForFound_Click(object sender, EventArgs e)
        {
            string res = Found.NumberOfObjects();
            resultTextForFound.Text = res;
        }

        private void createObjectButtonForDerived_Click(object sender, EventArgs e)
        {
            string name = nameEditForDerived.Text;
            double credit = 0, debit = 0;
            try
            {
                credit = double.Parse(creditEditForDerived.Text);
                debit = double.Parse(debitEdit.Text);
            }
            catch (Exception)
            {
                debitEdit.Text = "Некорректно заданы числовые данные!";
            }
            if (name != "")
                derived = new Derived(name, debit, credit);
            resultTextForDerived.Text = "Объект класса Derived успешно создан!";
        }

        private void virtualMethodButtonForDerived_Click(object sender, EventArgs e)
        {
            string res = derived.VirtualMethod();
            resultTextForDerived.Text = res;
        }

        private void nonVirtualMethodButtonForDerived_Click(object sender, EventArgs e)
        {
            string res = derived.NonVirtualMethod();
            resultTextForDerived.Text = res;
        }

        private void toStringButtonForDerived_Click(object sender, EventArgs e)
        {
            string res = derived.ToString();
            resultTextForDerived.Text = res;
        }

        private void parseButtonForDerived_Click(object sender, EventArgs e)
        {
            string res = derived.Parse();
            resultTextForDerived.Text = res;
        }

        private void jobButtonForDerived_Click(object sender, EventArgs e)
        {
            string res = derived.Job();
            resultTextForDerived.Text = res;
        }

        private void numberOfObjectButtonForDerived_Click(object sender, EventArgs e)
        {
            string res = Derived.NumberOfObjects();
            resultTextForDerived.Text = res;
        }
    }
}