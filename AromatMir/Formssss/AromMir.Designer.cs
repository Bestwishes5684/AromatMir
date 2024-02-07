namespace AromatMir.Formssss
{
    partial class AromMir
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1Name = new Label();
            AddOrder = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(-2, 161);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1126, 430);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1Name
            // 
            label1Name.AutoSize = true;
            label1Name.Location = new Point(724, 9);
            label1Name.Name = "label1Name";
            label1Name.Size = new Size(115, 15);
            label1Name.TabIndex = 1;
            label1Name.Text = "Вы зашли как гость";
            // 
            // AddOrder
            // 
            AddOrder.Location = new Point(12, 12);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(97, 43);
            AddOrder.TabIndex = 2;
            AddOrder.Text = "Добавить заказ";
            AddOrder.UseVisualStyleBackColor = true;
            AddOrder.Click += AddOrder_Click;
            // 
            // AromMir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 589);
            Controls.Add(AddOrder);
            Controls.Add(label1Name);
            Controls.Add(flowLayoutPanel1);
            Name = "AromMir";
            Text = "Ароматный мир ";
            Load += AromMir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1Name;
        private Button AddOrder;
    }
}