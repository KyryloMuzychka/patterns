using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Sakura : Tree
    {
        public override string GetDescriptionAboutTree()
        {
            return "Кілька дерев підродини «Сливові» називаються «сакурами» (часто сакурою позначають вишню дрібнопильчасту). Багато видів сакури є декоративними рослинами і не плодоносять.\r\n\r\nУ Другій світовій війні, сакура використовувалася в якості мотивуючого символу Японії. У своїх колоніях Японія намагалася садити квіти сакури, які було одним із способів висловлювання претензій на територію.\r\n\r\nВ Японії вишневий цвіт сакури символізує хмари.";
        }
        public override System.Drawing.Bitmap GetPictureOfTree()
        {
            return Properties.Resources.sakura;
        }
    }
}
