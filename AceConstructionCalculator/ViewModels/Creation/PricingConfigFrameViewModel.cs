using System;
namespace AceConstructionCalculator.ViewModels.Creation
{
    public class PricingConfigFrameViewModel : ViewModelBase
    {
        private string _currentCategory;
        public string CurrentCategory
        {
            get
            {
                return _currentCategory;
            }
            set
            {
                _currentCategory = value;
                OnPropertyChanged();
            }
        }
    }
}
