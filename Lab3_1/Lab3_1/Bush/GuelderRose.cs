using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class GuelderRose : Bush
    {
        public override string GetDescriptionAboutBush()
        {
            return "Звичайна калина багата на мінерали, вітаміни і модні нині антиоксиданти. У народній медицині використовують навіть її кору, не кажучи вже про ягоди і кісточки калини.\r\n\r\nПричому для настання цілющого ефекту в більшості випадків досить п'яти столових ложок самих ягід – або три-чотири чашки відвару (чаю) калини в день. Але сам курс лікування не повинен бути тривалим, попереджають експерти.";

        }
        public override System.Drawing.Bitmap GetPictureOfBush()
        {
            return Properties.Resources.guelder;
        }
    }
}
