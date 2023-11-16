using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows.Forms;

namespace Selenium
{
    public partial class Form1 : Form
    {
        private IWebDriver Driver;
        private SeleniumAutomation Selenium;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private TextBox ChromeDriverPathTextBox;
        private TextBox KeywordTextBox;
        private Button SearchButton;
        private WebBrowser WebBrowserControl;

        public Form1()
        {
            InitializeComponent();
            // Initialize ChromeDriver here or in Load event.
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            Driver = new ChromeDriver(chromeOptions);
            Selenium = new SeleniumAutomation(Driver);

            // Disable Selenium automation controls initially.
            //ChromeDriverPathTextBox.Enabled = false;
            //KeywordTextBox.Enabled = false;
            //SearchButton.Enabled = false;

        }

        // Handle the login button click event.
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            // Implement your user authentication logic here.
            if (IsValidUser(username, password))
            {
                EnableSeleniumAutomationControls();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        // Handle the Selenium automation button click event.
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string chromeDriverPath = ChromeDriverPathTextBox.Text;
            string keywordToSearch = KeywordTextBox.Text;

            // Configure and trigger the Selenium automation.
            Selenium.Search(keywordToSearch);
        }

        private bool IsValidUser(string username, string password)
        {
            // Implement your user authentication logic.

            // Return true if the user is valid; otherwise, return false.
            return true;
        }

        private void EnableSeleniumAutomationControls()
        {
            ChromeDriverPathTextBox.Enabled = true;
            KeywordTextBox.Enabled = true;
            SearchButton.Enabled = true;
        }

        // Dispose of the WebDriver when the form closes.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Driver.Quit();
        }
    }
}
