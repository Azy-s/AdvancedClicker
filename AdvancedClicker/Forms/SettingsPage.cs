
using System.Globalization;

namespace AdvancedClicker.Forms
{
    public partial class SettingsPage : Form
    {
        MainForm mainForm;
        public SettingsPage(MainForm form)
        {
            InitializeComponent();
            mainForm = form;
        }

        

        private void languageCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (languageComboBox.SelectedItem.ToString())
            {
                case "English":
                    ChangeLanguage("en");
                    break;
                case "Русский":
                    ChangeLanguage("ru");
                    break;
            }
        }

        private void ChangeLanguage(string langCode)
        {
            // Устанавливаем новый язык
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCode);
            // Пересоздаем форму для применения изменений
            //this.Controls.Clear();
            //InitializeComponent();
            mainForm.BeginInvoke(new Action(() => { mainForm.UpdateLocalization();}));
        }
    }
}
