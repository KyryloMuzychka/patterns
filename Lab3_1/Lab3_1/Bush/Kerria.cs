using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Kerria : Bush
    {
        public override string GetDescriptionAboutBush()
        {
            return "Цей декоративний чагарник, висаджений в правильному місті, не принесе вам абсолютно ніякого клопоту. Що любить керія? Найкраще вона почуватиметься в легкій напівтіні, правда, зможе рости і на повному сонці, але її квітування буде біднішим – квіти швидко вигорятимуть і осипатимуться. Крім того, керія японська – посухостійка рослина і в напівтіні зможе задовольнитися атмосферними опадами, а ось в сонячних місцях її доведеться все-таки поливати в посушливі періоди.\r\n\r\nДо ґрунтів цей чагарник також невибагливий, буде рости навіть на бідних піщаних. Але, знову ж таки, на сонці і на бідному ґрунті для нормального зростання їй буде потрібен регулярний полив.";
        }
        public override System.Drawing.Bitmap GetPictureOfBush()
        {
            return Properties.Resources.kerria;
        }
    }
}
