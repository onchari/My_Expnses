using System.Windows;
using System.Windows.Controls;

namespace My_Expenses
{
    /// <summary>
    ///     Interaction logic for ExpenseItHome.xaml
    /// </summary>
    public partial class ExpenseItHome : Page
    {
        public ExpenseItHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
           //View Expenses Report
           ExpenseReportPage expenseReportPage = new ExpenseReportPage();
            this.NavigationService.Navigate(expenseReportPage);

        }

        private void ViewButton_OnClick(object sender, RoutedEventArgs e)
        {
          ExpenseReportPage expenseReportPage = new ExpenseReportPage(this.PeopleListBox.SelectedItem);
            this.NavigationService.Navigate(expenseReportPage);
        }
    }
}