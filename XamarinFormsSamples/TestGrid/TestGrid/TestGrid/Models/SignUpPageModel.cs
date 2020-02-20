using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
using System.Threading.Tasks;
using TestGrid.Models;
using System.ComponentModel;

namespace TestGrid.Models
{
    public class SignUpPageModel
    {
        public string Email { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Rpass { get; set; }
        public string Image { get; set; }
        public bool IsPassword { get; set; } = true;
    }
}
