using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Chrysanthemum : Flower
    {
        public override string GetDescriptionAboutFlower()
        {
            return "Хризантеми – красиві осінні квіти, що радують око в саду до настання перших морозів. Ця квітка є також одною з найдавніших, оскільки відомо, що вже 2,5 тисячі років тому їх успішно вирощували в Китаї як декоративну рослину, тому квітка ця також відома як «китайські хризантеми».\r\n\r\nЗа деякими даними, китайці вживали листя хризантем в їжу. У перекладі з грецької, назва квітки перекладається терміном «золотоквіткова», оскільки квітки найдавніших сортів були пофарбовані в жовтий колір. Завдяки старанням сучасних садівників, зараз з’явилися сорти з білими, малиновими, бузковими, бордовими і іншими квітками.";
        }
        public override System.Drawing.Bitmap GetPictureOfFlower() 
        {
            return Properties.Resources.chrysanthemum;
        }
    }
}
