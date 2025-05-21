using System;
using System.Windows.Forms;

namespace IndividualOOP
{
    public partial class DrinkForm : Form
    {
        private OrderManager orderManager;

        public DrinkForm(OrderManager manager)
        {
            InitializeComponent();
            orderManager = manager;
            comboBoxDrinks.Items.AddRange(new string[] { "Coke", "Pepsi", "Water", "Juice" });
            comboBoxDrinks.SelectedIndex = 0;
        }

        private void buttonAddDrink_Click(object sender, EventArgs e)
        {
            string selectedDrink = comboBoxDrinks.SelectedItem.ToString();
            orderManager.AddDrink(new Drink() { Name = selectedDrink });
            this.Close();
        }
    }
}
