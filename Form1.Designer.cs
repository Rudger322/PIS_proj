namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы интерфейса
        private ComboBox comboBoxPurpose;
        private ComboBox comboBoxCountry;
        private DateTimePicker dateTimePickerEntryDate;
        private CheckBox checkBoxPolicy;
        private CheckBox checkBoxLongStay;
        private Button buttonSubmit;
        private Label labelPurpose;
        private Label labelCountry;
        private Label labelEntryDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxPurpose = new ComboBox();
            comboBoxCountry = new ComboBox();
            dateTimePickerEntryDate = new DateTimePicker();
            checkBoxPolicy = new CheckBox();
            checkBoxLongStay = new CheckBox();
            buttonSubmit = new Button();
            labelPurpose = new Label();
            labelCountry = new Label();
            labelEntryDate = new Label();
            buttonViewMap = new Button();
            labelInstructions = new Label();
            SuspendLayout();
            // 
            // comboBoxPurpose
            // 
            comboBoxPurpose.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPurpose.Location = new Point(150, 30);
            comboBoxPurpose.Name = "comboBoxPurpose";
            comboBoxPurpose.Size = new Size(200, 28);
            comboBoxPurpose.TabIndex = 0;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountry.Location = new Point(150, 70);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(200, 28);
            comboBoxCountry.TabIndex = 1;
            // 
            // dateTimePickerEntryDate
            // 
            dateTimePickerEntryDate.Location = new Point(150, 110);
            dateTimePickerEntryDate.Name = "dateTimePickerEntryDate";
            dateTimePickerEntryDate.Size = new Size(200, 27);
            dateTimePickerEntryDate.TabIndex = 2;
            // 
            // checkBoxPolicy
            // 
            checkBoxPolicy.Location = new Point(30, 186);
            checkBoxPolicy.Name = "checkBoxPolicy";
            checkBoxPolicy.Size = new Size(300, 20);
            checkBoxPolicy.TabIndex = 3;
            checkBoxPolicy.Text = "Есть медицинский полис";
            // 
            // checkBoxLongStay
            // 
            checkBoxLongStay.Location = new Point(30, 222);
            checkBoxLongStay.Name = "checkBoxLongStay";
            checkBoxLongStay.Size = new Size(300, 20);
            checkBoxLongStay.TabIndex = 4;
            checkBoxLongStay.Text = "Приехал(а) более чем на 90 дней";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(122, 266);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(150, 30);
            buttonSubmit.TabIndex = 5;
            buttonSubmit.Text = "Регистрация";
            buttonSubmit.Click += buttonRegister_Click;
            // 
            // labelPurpose
            // 
            labelPurpose.AutoSize = true;
            labelPurpose.Location = new Point(30, 30);
            labelPurpose.Name = "labelPurpose";
            labelPurpose.Size = new Size(108, 20);
            labelPurpose.TabIndex = 6;
            labelPurpose.Text = "Цель поездки:";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(30, 70);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(102, 20);
            labelCountry.TabIndex = 7;
            labelCountry.Text = "Гражданство:";
            // 
            // labelEntryDate
            // 
            labelEntryDate.AutoSize = true;
            labelEntryDate.Location = new Point(30, 110);
            labelEntryDate.Name = "labelEntryDate";
            labelEntryDate.Size = new Size(96, 20);
            labelEntryDate.TabIndex = 8;
            labelEntryDate.Text = "Дата въезда:";
            // 
            // buttonViewMap
            // 
            buttonViewMap.Location = new Point(122, 302);
            buttonViewMap.Name = "buttonViewMap";
            buttonViewMap.Size = new Size(150, 30);
            buttonViewMap.TabIndex = 9;
            buttonViewMap.Text = "Просмотр карты";
            buttonViewMap.Click += buttonViewMap_Click;
            // 
            // labelInstructions
            // 
            labelInstructions.AutoSize = true;
            labelInstructions.Location = new Point(30, 152);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(183, 20);
            labelInstructions.TabIndex = 10;
            labelInstructions.Text = "Отметьте галочкой, если:";
            // 
            // Form1
            // 
            ClientSize = new Size(387, 378);
            Controls.Add(buttonViewMap);
            Controls.Add(comboBoxPurpose);
            Controls.Add(comboBoxCountry);
            Controls.Add(dateTimePickerEntryDate);
            Controls.Add(checkBoxPolicy);
            Controls.Add(checkBoxLongStay);
            Controls.Add(buttonSubmit);
            Controls.Add(labelPurpose);
            Controls.Add(labelCountry);
            Controls.Add(labelEntryDate);
            Controls.Add(labelInstructions);
            Name = "Form1";
            Text = "Регистрация пользователя";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Button buttonViewMap;
        private Label labelInstructions;
    }
}
