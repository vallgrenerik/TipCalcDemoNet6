using Cirrious.MvvmCross.WindowsPhone.Views;
using CustomerManagement.Core.ViewModels;

namespace CustomerManagement.WindowsPhone.Views
{
    public abstract class BaseCustomerView : MvxPhonePage<DetailsCustomerViewModel> { }

    [MvxPhoneView("/Views/CustomerView.xaml")]
    public partial class CustomerView : BaseCustomerView
    {
        public CustomerView()
        {
            InitializeComponent();

            ApplicationTitle.Text = "Customer Management";
        }
    }
}