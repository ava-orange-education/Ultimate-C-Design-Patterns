using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using Chapter_16._02_Common_Antipatterns;

namespace Chapter_16._04_Avoid_antipaterns
{
    internal class UserController
    {
        private TextBox txtName;
        private Chapter_16._03_Practical_examples_Antipatterns.Web_Example.Context _dbContext;
        private UserService _userService;

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new _02_Common_Antipatterns.User { Name = txtName.Text };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        private void btnSave_Click1(object sender, EventArgs e)
        {
            var user = new User { Name = txtName.Text };
            _userService.Save(user);
        }

    }
}
