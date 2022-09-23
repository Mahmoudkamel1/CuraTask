using Foundation;
using System;
using System.Threading.Tasks;
using UIKit;
using xamarinIOSTask.Presentation.Home.View.DataSources;
using xamarinIOSTask.Presentation.Home.ViewModel;

namespace xamarinIOSTask
{
    public partial class ViewController : UIViewController
    {
        private HomeViewModel _viewModel => new HomeViewModel();
        private CollectionViewDetaSource _happyCustomersCollectionDataSourceDelegate;
        private CollectionViewDetaSource _doctorsCollectionViewDataSourceDelegate;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            _happyCustomersCollectionDataSourceDelegate = new CollectionViewDetaSource(DataSourceType.Reviews, happyReviewsCollectionView);
            _doctorsCollectionViewDataSourceDelegate = new CollectionViewDetaSource(DataSourceType.Doctors, doctorsCollectionView);
            happyReviewsCollectionView.DataSource = _happyCustomersCollectionDataSourceDelegate;
            happyReviewsCollectionView.Delegate = _happyCustomersCollectionDataSourceDelegate;
            doctorsCollectionView.DataSource = _doctorsCollectionViewDataSourceDelegate;
            doctorsCollectionView.Delegate = _doctorsCollectionViewDataSourceDelegate;
            await FetchData();
        }
        private async Task FetchData()
        {
            var reviews = await _viewModel.GetHappyCustomerReviews();
            _happyCustomersCollectionDataSourceDelegate.SetDataSource(reviews: reviews);
            await Task.Yield();
            var doctors = await _viewModel.GetDoctorAcceptInsurance();
            _doctorsCollectionViewDataSourceDelegate.SetDataSource(doctors: doctors);
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
       
    }
}
