using Microsoft.VisualBasic.Logging;
using System.Media;

namespace Lab3_2
{
    public partial class SoundsForm : Form
    {
        public SoundsForm()
        {
            InitializeComponent();
            InitializeHabitatComboBox();
        }

        private void habitatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHabitat = habitatComboBox.SelectedItem.ToString();
            InitializeAnimalsComboBox(selectedHabitat);
            Factory.CreateAnimalFactory(selectedHabitat);
            animalComboBox.Text = "";
            animalComboBox.SelectedIndex = -1;
        }

        private void animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (habitatComboBox.SelectedIndex != -1)
            {
                string selectedAnimal = animalComboBox.SelectedItem.ToString();
                Factory.CreateAnimal(selectedAnimal);
                ShowInfo(Factory.animal);
            }
        }

        void ShowInfo(Animal animal)
        {
            soundLabel.Text = animal.Speak();
            Factory.soundPlayer = CreateSoundFactory.CreateSoundOfAnimal();
            Factory.soundPlayer.Stream = animal.Sound();
            Factory.soundPlayer.Play();
        }

        void InitializeHabitatComboBox()
        {
            foreach (var el in DataUI.habitat)
            {
                habitatComboBox.Items.Add(el);
            }
        }

        void InitializeAnimalsComboBox(string AnimalType)
        {
            List<string> list;
            animalComboBox.Items.Clear();
            if (AnimalType == "Sea")
            {
                list = DataUI.animalSea;
            }
            else
            {
                list = DataUI.animalLand;
            }
            foreach (var el in list)
            {
                animalComboBox.Items.Add(el);
            }
        }
    }
}