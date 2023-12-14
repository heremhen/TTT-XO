namespace xoxo
{
    public partial class Form1 : Form
    {
        int player = 1, click = 0;
        public Form1()
        {
            InitializeComponent();
            WireUpButtons();
        }

        void WireUpButtons()
        {
            foreach (var btns in this.Controls.OfType<Button>())
            {
                btns.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                if (btn != null && btn.Text == "")
                {
                    btn.Text = (player == 1) ? "X" : "O";
                    player = (player == 1) ? 2 : 1;
                    btn.Enabled = false;

                    click++;
                    isWon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        void restart()
        {
            foreach (var btns in this.Controls.OfType<Button>())
            {
                btns.Text = "";
                btns.Enabled = true;
                click = 0;
            }
        }

        void isWon()
        {
            bool yalagch = false;

            // Check horizontal wins
            if ((a1.Text == a2.Text && a2.Text == a3.Text && a1.Enabled == false) ||
                (b1.Text == b2.Text && b2.Text == b3.Text && b1.Enabled == false) ||
                (c1.Text == c2.Text && c2.Text == c3.Text && c1.Enabled == false))
            {
                yalagch = true;
            }

            // Check vertical wins
            if ((a1.Text == b1.Text && b1.Text == c1.Text && a1.Enabled == false) ||
                (a2.Text == b2.Text && b2.Text == c2.Text && a2.Enabled == false) ||
                (a3.Text == b3.Text && b3.Text == c3.Text && a3.Enabled == false))
            {
                yalagch = true;
            }

            // Check diagonal wins
            if ((a1.Text == b2.Text && b2.Text == c3.Text && a1.Enabled == false) ||
                (a3.Text == b2.Text && b2.Text == c1.Text && a3.Enabled == false))
            {
                yalagch = true;
            }

            if (yalagch)
            {
                if (player == 1)
                    MessageBox.Show("Тоглогч 'O' яллаа!");
                else
                    MessageBox.Show("Тоглогч 'X' яллаа!");
                restart();
            }
            else if (click == 9)
            {
                MessageBox.Show("Тэнцлээ!");
                restart();
            }
        }


        private void a1_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void a2_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        
        private void b1_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;

                if (!(sender is Button))
                {
                    MessageBox.Show("Unexpected sender type.");
                    return;
                }

                if (player == 1)
                {
                    btn.Text = "X";
                    player = 2;
                }
                else
                {
                    btn.Text = "O";
                    player = 1;
                }
                btn.Enabled = false;

                click++;

                isWon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}