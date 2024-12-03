using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Controller controller = new Controller();

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxPurpose.Items.AddRange(controller.getRelevantPurpose().ToArray());
            comboBoxCountry.Items.AddRange(controller.getContries().ToArray());
            dateTimePickerEntryDate.Value = DateTime.Today;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedPurpose = comboBoxPurpose.SelectedItem?.ToString();
                string selectedCountry = comboBoxCountry.SelectedItem?.ToString();
                DateTime entryDate = dateTimePickerEntryDate.Value;
                bool hasPolicy = checkBoxPolicy.Checked;
                bool isLongStay = checkBoxLongStay.Checked;

                if (string.IsNullOrEmpty(selectedPurpose) || string.IsNullOrEmpty(selectedCountry))
                {
                    MessageBox.Show("Выберите цель и страну!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                controller.addInfo(
                    selectedCountry,
                    (Purpose)Enum.Parse(typeof(Purpose), selectedPurpose),
                    entryDate,
                    hasPolicy ? "Да" : "Нет",
                    isLongStay
                );

                MessageBox.Show("Данные успешно зарегистрированы.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewMap_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> mapPoints = controller.seeMap();
                string roadmapText = string.Join("\n", mapPoints);
                MessageBox.Show(roadmapText, "Дорожная карта", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

