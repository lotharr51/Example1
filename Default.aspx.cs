using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsExample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void colorListDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorLabel.Text = colorListDropDown.SelectedValue;

            SetNotSelectedColorList();
        }

        protected void ColorListDropDown_DataBound(object sender, EventArgs e)
        {
            colorLabel.Text = colorListDropDown.SelectedValue;

            SetNotSelectedColorList();
        }

        //Not using try/catch since this is so basic. Error processing always has to be considered during design.
        private void  SetNotSelectedColorList()
        {
            String colorList = "";

            int colorCount = colorListDropDown.Items.Count;

            for (int i = 0; i < colorCount; i++)
            {
                if (colorListDropDown.Items[i].ToString() != colorListDropDown.SelectedValue)
                {
                    colorList += colorListDropDown.Items[i].ToString() + ", ";
                }
            }

            colorList = colorList.Remove(colorList.LastIndexOf(","));

            colorsNotSelected.Text = colorList;
        }
    }
}