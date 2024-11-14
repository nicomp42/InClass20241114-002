using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass20241114_002
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Only run this if it's not a post back
            {
                // How can we run this only one time?
                // This method runs when the page is loaded into a browser
                // Add a pizza company to the list box
                // lbPizzaCompanies.Items.Clear();
                lbPizzaCompanies.Items.Add("LaRosa's");
                // Add a few more items to the list box
                lbPizzaCompanies.Items.Add("Grammas");
                lbPizzaCompanies.Items.Add("Adriatico's");

                cblIngredients.Items.Add("Mushrooms");
                cblIngredients.Items.Add("Green Olives");
                cblIngredients.Items.Add("Bacon");
            }
        }

        protected void cmdSelectPizzaCompany_Click(object sender, EventArgs e)
        {
            // We call this an "event handler"
            // This code runs when the cmdSelectPizzaCompany button is clicked
            // Write the currently selected pizza company in the list box into the label
            // We are using the Text property of the label
            // We need to get the item from the list box
            lblSelectedPizzaCompany.Text = lbPizzaCompanies.Text;
        }
    }
}