using System.Windows.Controls;

namespace My_Expenses
{
    /// <summary>
    ///     Interaction logic for ExpenseReportPage.xaml
    /// </summary>
    public partial class ExpenseReportPage : Page
    {
        public ExpenseReportPage()
        {
            InitializeComponent();
        }

        public ExpenseReportPage(object data) : this()
        {
            this.DataContext = data;
        }
    }
}