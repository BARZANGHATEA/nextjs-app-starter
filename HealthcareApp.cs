using System;
using System.Drawing;
using System.Windows.Forms;

namespace HealthcareApplication
{
    public partial class HealthcareForm : Form
    {
        private Panel sideMenu;
        private Panel mainContent;
        private PictureBox logoBox;

        public HealthcareForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void InitializeComponent()
        {
            this.Text = "Heart Hospital";
            this.Size = new Size(1200, 800);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Create side menu panel
            sideMenu = new Panel
            {
                BackColor = Color.White,
                Size = new Size(250, this.ClientSize.Height),
                Dock = DockStyle.Left
            };

            // Create logo
            logoBox = new PictureBox
            {
                Size = new Size(50, 50),
                Location = new Point(20, 20),
                BackColor = Color.Red,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Create menu buttons
            Button[] menuButtons = new[]
            {
                CreateMenuButton("Home", 100),
                CreateMenuButton("My Health Status", 160),
                CreateMenuButton("Health Journals", 220),
                CreateMenuButton("My Appointments", 280),
                CreateMenuButton("Login/Register", 340)
            };

            // Add controls
            sideMenu.Controls.Add(logoBox);
            foreach (var button in menuButtons)
            {
                sideMenu.Controls.Add(button);
            }

            // Create main content panel
            mainContent = new Panel
            {
                BackColor = Color.WhiteSmoke,
                Dock = DockStyle.Fill
            };

            // Add panels to form
            this.Controls.Add(mainContent);
            this.Controls.Add(sideMenu);
        }

        private Button CreateMenuButton(string text, int yPosition)
        {
            Button button = new Button
            {
                Text = text,
                Size = new Size(210, 40),
                Location = new Point(20, yPosition),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Padding = new Padding(10, 0, 0, 0)
            };

            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;

            button.MouseEnter += (s, e) => {
                button.BackColor = Color.FromArgb(245, 245, 245);
            };

            button.MouseLeave += (s, e) => {
                button.BackColor = Color.White;
            };

            return button;
        }

        private void SetupForm()
        {
            // Add any additional setup code here
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HealthcareForm());
        }
    }
}
