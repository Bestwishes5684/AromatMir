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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1Name = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 161);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1126, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1Name
            // 
            this.label1Name.AutoSize = true;
            this.label1Name.Location = new System.Drawing.Point(724, 9);
            this.label1Name.Name = "label1Name";
            this.label1Name.Size = new System.Drawing.Size(115, 15);
            this.label1Name.TabIndex = 1;
            this.label1Name.Text = "Вы зашли как гость";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(12, 12);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(97, 43);
            this.AddOrder.TabIndex = 2;
            this.AddOrder.Text = "Добавить Товар";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click_1);
            // 
            // AromMir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 589);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.label1Name);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AromMir";
            this.Text = "Ароматный мир ";
            this.Load += new System.EventHandler(this.AromMir_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1Name;
        private Button AddOrder;
    }
}