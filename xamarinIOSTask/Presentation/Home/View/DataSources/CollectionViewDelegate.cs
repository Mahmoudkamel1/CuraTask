using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using xamarinIOSTask.ApplicationCore.Helper;
using xamarinIOSTask.Domain.Entity;

namespace xamarinIOSTask.Presentation.Home.View.DataSources
{
    public class CollectionViewDetaSource : UICollectionViewController
    {
        private List<Review> _reviews;
        private List<Doctor> _doctors;
        private DataSourceType _type;
        private UICollectionView _collectionView;
        public CollectionViewDetaSource(DataSourceType type,UICollectionView collectionView)
        {
            _type = type;
            _collectionView = collectionView;
            if (_type == DataSourceType.Doctors)
            {
                this._doctors = new List<Doctor>();
            }
            else
            {
                this._reviews = new List<Review>();
            }
        }
        public void SetDataSource(List<Review> reviews = null, List<Doctor> doctors = null)
        {
            if (_type == DataSourceType.Doctors)
            {
                this._doctors = doctors;
            }
            else
            {
                this._reviews = reviews;
            }
            _collectionView.ReloadData();
        }
        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return _type == DataSourceType.Doctors ? _doctors.Count : _reviews.Count;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            if (_type == DataSourceType.Reviews)
            {
                var reviewCell = (ReviewCell)collectionView.DequeueReusableCell(Constants.ReviewCellIdentifier, indexPath);
                var review = _reviews[indexPath.Row];
                reviewCell.ConfigureCell(review);
                return reviewCell;
            }
            else
            {
                var doctorCell = (DoctorCell)collectionView.DequeueReusableCell(Constants.DoctorCellIdentifier, indexPath);

                var doctor = _doctors[indexPath.Row];
                doctorCell.ConfigureCell(doctor);
                return doctorCell;
            }
        }

    }
}
