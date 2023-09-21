using System.IO;

namespace Lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Character ch1 = new Electrophor();
            Character ch2 = new Shadowblade();
            Character ch3 = new Volcano();

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