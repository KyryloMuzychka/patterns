using Microsoft.Azure.Amqp.Framing;
using System.ComponentModel;
using System.Resources;
using System.Windows.Forms;

namespace Lab3_1
{
    public partial class PlantsForm : Form
    {
        public PlantsForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
            SetImage();
        }

        void InitializeComboBoxes()
        {            
            foreach (var el in DataUI.country)
            {
                countryComboBox.Items.Add(el);
            }
            foreach (var el in DataUI.plants)
            {
                plantComboBox.Items.Add(el);
            }
            countryComboBox.SelectedIndex = 0;
            plantComboBox.SelectedIndex = 0;
        }

        void SetImage()
        {
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = countryComboBox.SelectedItem.ToString();

            switch (selectedCountry)
            {
                case "Ukraine":
                    Ukraine();
                    break;
                case "Japan":
                    Japan();
                    break;
            }

            plantComboBox.SelectedIndex = 0;
            string selectedPlant = plantComboBox.SelectedItem.ToString();
            ChangeDescription(selectedPlant);
        }

        private void plantComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlant = plantComboBox.SelectedItem.ToString();
            ChangeDescription(selectedPlant);
        }

        void Ukraine()
        {
            Factory.CreateUkraineFactory();
            Factory.CreatePlantWorld(Factory.ukraineFactory);
        }

        void Japan()
        {
            Factory.CreateJapanFactory();
            Factory.CreatePlantWorld(Factory.japanFactory);  
        }

        void ChangeDescription(string selectedItem)
        {
            switch (selectedItem)
            {
                case "Tree":
                    descriptionTextBox.Text = Factory.world.tree.GetDescriptionAboutTree();
                    picture.Image = Factory.world.tree.GetPictureOfTree();
                    break;
                case "Flower":
                    descriptionTextBox.Text = Factory.world.flower.GetDescriptionAboutFlower();
                    picture.Image = Factory.world.flower.GetPictureOfFlower();
                    break;
                case "Bush":
                    descriptionTextBox.Text = Factory.world.bush.GetDescriptionAboutBush();
                    picture.Image = Factory.world.bush.GetPictureOfBush();
                    break;
            }
        }
    }
}