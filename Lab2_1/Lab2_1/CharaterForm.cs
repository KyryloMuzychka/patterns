using System.IO;

namespace Lab2_1
{
    public partial class CharaterForm : Form
    {
        public CharaterForm()
        {
            InitializeComponent();            
            InitializeNameBox();
        }

        private void InitializeNameBox()
        {
            Factory.CreateFactory();
            foreach (Character ch in Character.charaters)
            {
                nameBox.Items.Add(ch.GetName());
            }
        }

        private void nameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = nameBox.SelectedItem.ToString();
            Character character = Character.charaters.FirstOrDefault(ch => ch.GetName() == selectedState);
            if (character != null)
            {
                nameText.Text = character.GetName();
                powerText.Text = character.Power();
                weaponsText.Text = "";
                foreach (string weapon in character.GetWeapons())
                {
                    weaponsText.Text += weapon + "\r\n";
                }
            }
        }
    }
}