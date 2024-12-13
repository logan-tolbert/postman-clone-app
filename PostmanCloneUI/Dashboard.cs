using PostmanCloneLibrary;
using System.CodeDom.Compiler;

namespace PostmanCloneUI
{
    public partial class Dashboard : Form
    {
        private readonly ApiAccess api = new ApiAccess();
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void requestButton_Click(object sender, EventArgs e)
        {   
            // TODO: Add API URL Validation
            if (requestField.Text == "")
            {
                responseWindow.Text = "Please enter a valid URL";
                statusLabel.Text = "Error"; 
            }

            
            try
            {
                statusLabel.Text = "Requesting....";

                responseWindow.Text = await api.CallApiAsync(requestField.Text);

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
