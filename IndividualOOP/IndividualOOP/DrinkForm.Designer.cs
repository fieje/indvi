namespace IndividualOOP
{
    partial class DrinkForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDrinks;
        private System.Windows.Forms.Button buttonAddDrink;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxDrinks = new System.Windows.Forms.ComboBox();
            this.buttonAddDrink = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // comboBoxDrinks
            this.comboBoxDrinks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDrinks.Location = new System.Drawing.Point(20, 20);
            this.comboBoxDrinks.Name = "comboBoxDrinks";
            this.comboBoxDrinks.Size = new System.Drawing.Size(200, 21);

            // buttonAddDrink
            this.buttonAddDrink.Location = new System.Drawing.Point(20, 60);
            this.buttonAddDrink.Name = "buttonAddDrink";
            this.buttonAddDrink.Size = new System.Drawing.Size(100, 25);
            this.buttonAddDrink.Text = "Add Drink";
            this.buttonAddDrink.Click += new System.EventHandler(this.buttonAddDrink_Click);

            // DrinkForm
            this.ClientSize = new System.Drawing.Size(250, 110);
            this.Controls.Add(this.comboBoxDrinks);
            this.Controls.Add(this.buttonAddDrink);
            this.Name = "DrinkForm";
            this.Text = "Choose Drink";
        }

    }
}