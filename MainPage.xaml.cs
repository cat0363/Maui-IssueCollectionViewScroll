using System.Collections.ObjectModel;

namespace Maui_IssueCollectionViewScroll
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<ViewModelTest> pTestList = new ObservableCollection<ViewModelTest>();

        public MainPage()
        {
            InitializeComponent();            
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            if (pTestList.Count != 0)
            {
                cvTestList.ItemsSource = pTestList;
            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    pTestList.Add(new ViewModelTest() { ItemName = "Item " + string.Format("{0:D3}", i + 1) });
                }
                cvTestList.ItemsSource = pTestList;
            }

        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                pTestList.RemoveAt(pTestList.Count - 1);
            }
            for (int i = 0; i < 3; i++)
            {
                pTestList.Add(new ViewModelTest() { ItemName = "Item " + string.Format("{0:D3}", pTestList.Count + 1) });
            }
        }
    }

    public class ViewModelTest
    {
        public string ItemName { get; set; }
    }
}
