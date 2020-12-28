/* William Lee Jarboe
 * CMPS 4143-101
 * Prof. Stringfellow
 * Program 7 - Inventory MDI
 * File: LoginUserPswdForm.cs
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

namespace LoginPswdUserControl
{
    public partial class LoginUserPswdForm : UserControl
    {
        //login string - private, public accessor.
        private String login = "";
        public String Login
        {
            get
            {
                return login;
            }
        }
        //password string - private, public accessor.
        private String pass = "";
        public String Password
        {
            get
            {
                return pass;
            }
        }

        /// <summary>
        /// Author: William Lee Jarboe
        /// Date: 12/1/2020
        /// Purpose: Constructor for component. called by external sources.
        /// </summary>
        public LoginUserPswdForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Author: William Lee Jarboe
        /// Date: 12/2/2020
        /// Purpose: This one was weird at first but i really like it. I made an event that can be set in a program that uses this as a control.
        /// it essentially lets other apps handle the event.
        /// </summary>
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user submits information")]
        public event EventHandler ButtonClick;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
            {
                //send event!
                this.ButtonClick(this, e);
            }
        }
    }
}
