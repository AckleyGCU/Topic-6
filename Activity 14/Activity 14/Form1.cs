using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fontsListBox.SelectedIndex = 10;
        }
        private void fontControl(object sender, EventArgs e)
        {
            //Initializes the font family that will be used. Is based off the list box selection.
            FontFamily fontFamily = new FontFamily(fontsListBox.SelectedItem.ToString());
            //Used for temporarily storing the font style selctions.
            Font newFont = new Font(textBox.Font, FontStyle.Regular); ;

            //Conditionals are used to see which radio button is checked
            //When a radio button is selected the corrisponding font style is stored in the newFont variable.
            if (fontStyleReg.Checked)
            {
                newFont = new Font(textBox.Font, FontStyle.Regular);
            }
            else if (fontStyleObl.Checked)
            {
                newFont = new Font(textBox.Font, FontStyle.Italic);
            }
            else if (fontStyleBold.Checked)
            {
                newFont = new Font(textBox.Font, FontStyle.Bold);
            }
            else if (fontStyleBoldObl.Checked)
            {
                newFont = new Font(textBox.Font, FontStyle.Bold ^ FontStyle.Italic);
            }

            //These conditionals will check to see what combination of check bocxes are selected.
            //Once the combination is determined the correct font effects are applied along with the stored font styles.
            if (underline.Checked && strikeOut.Checked)
            {
                textBox.Font = new Font(fontFamily, textBox.Font.SizeInPoints, FontStyle.Strikeout ^ FontStyle.Underline ^ newFont.Style);
            }
            else if (!underline.Checked && strikeOut.Checked)
            {
                textBox.Font = new Font(fontFamily, textBox.Font.SizeInPoints, FontStyle.Strikeout ^ newFont.Style);
            }
            else if(underline.Checked && !strikeOut.Checked)
            {
                textBox.Font = new Font(fontFamily, textBox.Font.SizeInPoints, FontStyle.Underline ^ newFont.Style);
            }
            else if(!underline.Checked && !strikeOut.Checked)
            {
               textBox.Font = new Font(fontFamily, textBox.Font.SizeInPoints, newFont.Style);
            }
        }
    }
}
