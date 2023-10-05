using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Oak : Tree
    {
        public override string GetDescriptionAboutTree()
        {
            return "У Північній півкулі росте близько 450 видів дуба, в Південному — близько 50 видів. Ця рослина любить світло і тепло, воно росте на рівнинах або невисоких горах. У тайзі це дерево зустрічається дуже рідко.\r\n\r\nЦі дерева можуть бути листяними (скидають листя взимку) або вічнозеленими (круглий рік зберігають листя.)\r\n\r\nВиростають з жолудів. Жолуді дуже люблять їсти дикі свині (домашні свині теж можуть їсти жолуді). Розриваючи землю своїми копитами, вони сприяють зростанню цих дерев.";
        }
        public override System.Drawing.Bitmap GetPictureOfTree()
        {
            return Properties.Resources.oak;
        }
    }
}
