/* William Lee Jarboe
 * CMPS 4143-101
 * Prof. Stringfellow
 * Program 7 - Inventory MDI
 * File: insertUpdateForm.cs
 * Summary: an introductory project into Multi-Document Inventories.
 * Result: I had fun on this one. :)
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoresOwner
{
    /// <summary>
    /// Author: William Lee Jarboe
    /// Date: 12/2/2020
    /// Purpose: allows the user to update their saved information.
    /// </summary>
    public partial class insertUpdateForm : Form
    {
        
        string title;
        public Record r = null;

        /// <summary>
        /// Author: William Lee Jarboe
        /// Date: 12/2/2020
        /// Purpose: Constructor #1 - just takes a store title. keeps record r null.
        /// </summary>
        /// <param name="storeTitle"></param>
        public insertUpdateForm(string storeTitle)
        {
            InitializeComponent();
            //save title string
            title = "Inserting an item into " + storeTitle;

        }

        /// <summary>
        /// Author: William Lee Jarboe
        /// Date: 12/2/2020
        /// Purpose: Constructor #2 - specifies this is an update by providing record data.
        /// </summary>
        /// <param name="storeTitle"></param>
        /// <param name="rec"></param>
        public insertUpdateForm(string storeTitle, Record rec)
        {
            InitializeComponent();
            //save title string
            title = "Updating an item from " + storeTitle;
            //we want to make it easy for the user to update the record...
            this.r = rec;
        }

        /// <summary>
        /// Author: William Lee Jarboe
        /// Date: 12/2/2020
        /// Purpose: Onload that deals with conditional text box prep.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertUpdateForm_Load(object sender, EventArgs e)
        {
            //if it is an update...
            if(r!=null)
            {
                //auto fill the boxes for the user so they have to only
                //type minimally to make the changes they would like.
                txbID.Text = r.ID+"";
                txbName.Text = r.Name;
                txbPrice.Text = r.Price+"";
                txbQuantity.Text = r.Quantity + "";
                txbStore.Text = r.Store;
            }
            //regardless, set window title.
            this.Text = title;
        }

        /// <summary>
        /// Author: William Lee Jarboe
        /// Date: 12/2/2020
        /// Purpose: finalize the piece of data we'll be sending back, give the "A-OK" that is DialogResult.OK and exit stage left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //the ONLY REASON this is a try, is so that people don't break it with non-numbers.
            try
            {
                //compile record
                r = new Record(int.Parse(txbID.Text),txbName.Text, txbStore.Text, double.Parse(txbPrice.Text), int.Parse(txbQuantity.Text) );
                //say we are happy
                DialogResult = DialogResult.OK;
                //leave
                Close();
            }
            catch(Exception f)
            {
                //it's their problem not mine xd
                lblCurrentlyAdding.Text = f.ToString();
            }
        }
    }
}
