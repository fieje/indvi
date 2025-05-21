using System;

namespace IndividualOOP
{
    partial class PizzaOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxPizzaName;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckBox checkBoxCheese;
        private System.Windows.Forms.CheckBox checkBoxPepperoni;
        private System.Windows.Forms.CheckBox checkBoxMushrooms;
        private System.Windows.Forms.Button buttonAddPizza;
        private System.Windows.Forms.Button buttonAddDrink;
        private System.Windows.Forms.ListBox listBoxPizzas;
        private System.Windows.Forms.ListBox listBoxDrinks;

        public EventHandler PizzaOrderForm_Load { get; private set; }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PizzaOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "PizzaOrderForm";
            this.Load += new System.EventHandler(this.PizzaOrderForm_Load);
            this.ResumeLayout(false);

        }
    }
}
