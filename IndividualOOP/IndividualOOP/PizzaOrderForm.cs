using System;
using System.Windows.Forms;

namespace IndividualOOP
{
    public partial class PizzaOrderForm : Form
    {
        private OrderManager orderManager;

        public PizzaOrderForm()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            comboBoxSize.Items.AddRange(new string[] { "Small", "Medium", "Large" });
            comboBoxSize.SelectedIndex = 0;
        }

        private void buttonAddPizza_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza()
            {
                Name = textBoxPizzaName.Text,
                Size = comboBoxSize.SelectedItem.ToString(),
                Cheese = checkBoxCheese.Checked,
                Pepperoni = checkBoxPepperoni.Checked,
                Mushrooms = checkBoxMushrooms.Checked
            };

            orderManager.AddPizza(pizza);
            listBoxPizzas.Items.Add(pizza.ToString());

            // Очистка
            textBoxPizzaName.Clear();
            checkBoxCheese.Checked = false;
            checkBoxPepperoni.Checked = false;
            checkBoxMushrooms.Checked = false;
        }

        private void buttonAddDrink_Click(object sender, EventArgs e)
        {
            var drinkForm = new DrinkForm(orderManager);
            drinkForm.ShowDialog();

            // Оновлення списку напоїв після закриття DrinkForm
            listBoxDrinks.Items.Clear();
            foreach (var drink in orderManager.Drinks)
            {
                listBoxDrinks.Items.Add(drink.ToString());
            }
        }
    }
}
