namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void requestButton_Click(object sender, EventArgs e)
        {   // TODO: Add API URL Validation
            try
            {
                statusLabel.Text = "Requesting....";

                //TODO: Add API call
                await Task.Delay(2000);

                statusLabel.Text = "Ready";
            }
            catch (Exception ex)
            {
                responseWindow.Text = "Error: " + ex.Message;
                statusLabel.Text = "Error";
            }
        }
    }
}
