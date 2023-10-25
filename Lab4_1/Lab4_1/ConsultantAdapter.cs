using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class ConsultantAdapter : Position
    {
        private Consultant consultant;

        public ConsultantAdapter()
        {
            this.consultant = new Consultant();
        }
          
        public string Surname
        {
            get => consultant.Name;
            set => consultant.Name = value;
        }

        public string Work()
        {
           return consultant.ShowFriendlyAttitudeToClient();
        }
    }
}
