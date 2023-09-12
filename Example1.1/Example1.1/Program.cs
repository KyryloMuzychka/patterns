using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Example1._1 
{

        /// <summary>
        /// Класс поставщик,предоставляет клиентам
        /// статический и зкземплярный методы,
        /// закрывая поля класса
        /// </summary>

        class Provider
        {
            //fileds
            string fieldP1;
            int fieldP2;
            static int fieldPS;
            //Конструкторы класса
            /// <summary>
            /// Конструктор с аргументами
            /// </summary>
            /// <param name="p1">аргумент,инициализирующий поле класса</param>
            /// <param name="p2">аргумент,инициализирующий поле класса</param>

            public Provider(string p1, int p2)
            {
                fieldP1 = p1.ToUpper(); fieldP2 = p2 * 2;
                fieldPS = 0;
            }

            public Provider()
            {
                fieldP1 = ""; fieldP2 = 0; fieldPS = 0;
            }

            //Динамический (Экземплярный) метод
            public string MethodPD()
            {
                fieldPS++;
                string res = "Объект класса Provider" + "\n\r";
                res += string.Format("Мои поля: поле1 = {0}, поле2 = {1}",
                    fieldP1, fieldP2);
                return res;
            }
            // Статический (Модульный) метод
            public static string MethodPS()
            {
                string res = "Модуль класса Provider" + "\n\r";
                res += string.Format("Число вызовов метода MethodPD = {0}",
                    fieldPS.ToString());
                return res;
            }



        }

        class Client
        {
            //fields
            Provider provider;
            string fieldC1;
            int fieldC2;
            const string NEWLINE = "\n\r";
            //Конструкторы класса
            public Client(string p1, int p2, string c1, int c2)
            {
                fieldC1 = c1.ToLower(); fieldC2 = c2 - 2;
                provider = new Provider(p1, p2);
            }
            public Client()
            {
                fieldC1 = ""; fieldC2 = 0;
                provider = new Provider();
            }
            /// <summary>
            /// Метод, использующий поле класса provider
            /// для работы с методами класса Provider
            /// </summary>
            /// <returns>композиция строк провайдера и клиента </returns>
            public string MethodClient1()
            {
                string res = provider.MethodPD() + NEWLINE;
                res += "Объект класса Client" + NEWLINE;
                res += string.Format("Мои поля: поле1 = {0}, поле2 = {1}",
                    fieldC1, fieldC2);
                return res;
            }
        }


    class Programm
    {
        static void Main() 
        {
            Console.OutputEncoding = Encoding.UTF8;
            Client client = new Client("oblect of class Provider", 33, "object of class client", 44);
            string res = client.MethodClient1();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }

}
