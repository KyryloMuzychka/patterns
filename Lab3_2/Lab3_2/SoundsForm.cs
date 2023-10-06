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

            switch (selectedHabitat)
            {
                case "Land":
                    Land();
                    break;
                case "Sea":
                    Sea();
                    break;
            }
            animalComboBox.Text = "";
            animalComboBox.SelectedIndex = -1;
        }

        private void animalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (habitatComboBox.SelectedIndex != -1)
            {
                string selectedAnimal = animalComboBox.SelectedItem.ToString();

                switch (selectedAnimal)
                {
                    case "Dog":
                        Animal dog = Factory.landFactory.GetAnimal("Dog");
                        ShowInfo(dog);
                        break;
                    case "Cat":
                        Animal cat = Factory.landFactory.GetAnimal("Cat");
                        ShowInfo(cat);
                        break;
                    case "Lion":
                        Animal lion = Factory.landFactory.GetAnimal("Lion");
                        ShowInfo(lion);
                        break;
                    case "Octopus":
                        Animal octopus = Factory.seaFactory.GetAnimal("Octopus");
                        ShowInfo(octopus);
                        break;
                    case "Shark":
                        Animal shark = Factory.seaFactory.GetAnimal("Shark");
                        ShowInfo(shark);
                        break;
                }
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

        void Land()
        {
            Factory.landFactory = AnimalFactory.CreateAnimalFactory("Land");
        }

        void Sea()
        {
            Factory.seaFactory = AnimalFactory.CreateAnimalFactory("Sea");
        }
    }
}