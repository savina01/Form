
namespace PizzaOrder
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.panelButtonAdd = new System.Windows.Forms.Panel();
            this.panelButtonDelete = new System.Windows.Forms.Panel();
            this.labelPerson = new System.Windows.Forms.Label();
            this.textBoxNameSearch = new System.Windows.Forms.TextBox();
            this.groupBoxOrdersByName = new System.Windows.Forms.GroupBox();
            this.panelAllButtons = new System.Windows.Forms.Panel();
            this.ButtonDelivery = new System.Windows.Forms.Button();
            this.panelButtonAdd.SuspendLayout();
            this.panelButtonDelete.SuspendLayout();
            this.groupBoxOrdersByName.SuspendLayout();
            this.panelAllButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(11, 27);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(325, 308);
            this.listBoxOrders.TabIndex = 3;
            this.listBoxOrders.DoubleClick += new System.EventHandler(this.listBoxOrders_DoubleClick);
            this.listBoxOrders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxOrders_KeyDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(6, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 33);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNewOrder.Location = new System.Drawing.Point(6, 6);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(146, 35);
            this.buttonNewOrder.TabIndex = 5;
            this.buttonNewOrder.Text = "New order";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelButtonAdd
            // 
            this.panelButtonAdd.Controls.Add(this.buttonNewOrder);
            this.panelButtonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonAdd.Location = new System.Drawing.Point(0, 45);
            this.panelButtonAdd.Name = "panelButtonAdd";
            this.panelButtonAdd.Padding = new System.Windows.Forms.Padding(6);
            this.panelButtonAdd.Size = new System.Drawing.Size(158, 47);
            this.panelButtonAdd.TabIndex = 6;
            // 
            // panelButtonDelete
            // 
            this.panelButtonDelete.Controls.Add(this.buttonDelete);
            this.panelButtonDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonDelete.Location = new System.Drawing.Point(0, 0);
            this.panelButtonDelete.Name = "panelButtonDelete";
            this.panelButtonDelete.Padding = new System.Windows.Forms.Padding(6);
            this.panelButtonDelete.Size = new System.Drawing.Size(158, 45);
            this.panelButtonDelete.TabIndex = 7;
            // 
            // labelPerson
            // 
            this.labelPerson.AutoSize = true;
            this.labelPerson.Location = new System.Drawing.Point(12, 9);
            this.labelPerson.Name = "labelPerson";
            this.labelPerson.Size = new System.Drawing.Size(207, 17);
            this.labelPerson.TabIndex = 5;
            this.labelPerson.Text = "Search order by person\'s name";
            // 
            // textBoxNameSearch
            // 
            this.textBoxNameSearch.Location = new System.Drawing.Point(15, 29);
            this.textBoxNameSearch.Name = "textBoxNameSearch";
            this.textBoxNameSearch.Size = new System.Drawing.Size(502, 22);
            this.textBoxNameSearch.TabIndex = 8;
            this.textBoxNameSearch.TextChanged += new System.EventHandler(this.textBoxNameSearch_TextChanged);
            // 
            // groupBoxOrdersByName
            // 
            this.groupBoxOrdersByName.Controls.Add(this.panelAllButtons);
            this.groupBoxOrdersByName.Controls.Add(this.listBoxOrders);
            this.groupBoxOrdersByName.Location = new System.Drawing.Point(15, 57);
            this.groupBoxOrdersByName.Name = "groupBoxOrdersByName";
            this.groupBoxOrdersByName.Size = new System.Drawing.Size(502, 351);
            this.groupBoxOrdersByName.TabIndex = 9;
            this.groupBoxOrdersByName.TabStop = false;
            this.groupBoxOrdersByName.Text = "Orders by name";
            // 
            // panelAllButtons
            // 
            this.panelAllButtons.Controls.Add(this.ButtonDelivery);
            this.panelAllButtons.Controls.Add(this.panelButtonAdd);
            this.panelAllButtons.Controls.Add(this.panelButtonDelete);
            this.panelAllButtons.Location = new System.Drawing.Point(344, 21);
            this.panelAllButtons.Name = "panelAllButtons";
            this.panelAllButtons.Size = new System.Drawing.Size(158, 314);
            this.panelAllButtons.TabIndex = 11;
            // 
            // ButtonDelivery
            // 
            this.ButtonDelivery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonDelivery.Location = new System.Drawing.Point(0, 279);
            this.ButtonDelivery.Name = "ButtonDelivery";
            this.ButtonDelivery.Size = new System.Drawing.Size(158, 35);
            this.ButtonDelivery.TabIndex = 10;
            this.ButtonDelivery.Text = "Delivery";
            this.ButtonDelivery.UseVisualStyleBackColor = true;
            this.ButtonDelivery.Click += new System.EventHandler(this.ButtonDelivery_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 416);
            this.Controls.Add(this.groupBoxOrdersByName);
            this.Controls.Add(this.textBoxNameSearch);
            this.Controls.Add(this.labelPerson);
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.panelButtonAdd.ResumeLayout(false);
            this.panelButtonDelete.ResumeLayout(false);
            this.groupBoxOrdersByName.ResumeLayout(false);
            this.panelAllButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Panel panelButtonAdd;
        private System.Windows.Forms.Panel panelButtonDelete;
        private System.Windows.Forms.Label labelPerson;
        private System.Windows.Forms.TextBox textBoxNameSearch;
        private System.Windows.Forms.GroupBox groupBoxOrdersByName;
        private System.Windows.Forms.Panel panelAllButtons;
        private System.Windows.Forms.Button ButtonDelivery;
    }
}
