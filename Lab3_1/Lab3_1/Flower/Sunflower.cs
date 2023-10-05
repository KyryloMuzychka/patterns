using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Sunflower : Flower
    {
        public override string GetDescriptionAboutFlower()
        {
            return "Україна – лідер з виробництва соняшнику та найбільший експортер соняшникової олії у світі (5,6 млн. тон = 57% всього експорту).\r\n\r\nСоняшник завжди повертається убік сонця, це явище називається «геліотропізм». Навіть у хмарну погоду капелюшок соняшнику показує, де перебуває зараз сонце відносно горизонту.\r\n\r\nНайвищий соняшник в світі виростили в Німеччині в 2009 році, його висота сягала 8,03 метри. В Україні зафіксовано найбільший соняшник висотою 4 метри 17 см, що був вирощений у 2011 році в с. Плесецьке Васильківського району Київської області.";
        }
        public override System.Drawing.Bitmap GetPictureOfFlower()
        {
            return Properties.Resources.sunflower;
        }
    }
}
