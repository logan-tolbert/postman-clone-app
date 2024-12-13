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
