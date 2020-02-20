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
    public class LoginPageModel
    {
        public string Mail { get; set; }
        public string EntryPass { get; set; }
        public bool IsPassword { get; set; }
        public string Image { get; set; }
    }
}
