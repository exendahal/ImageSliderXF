using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ImageSlider
{
    public class sliderImageViewModel : INotifyPropertyChanged
    {
        readonly IList<sliderImage> source;
        public ObservableCollection<sliderImage> sliderImage { get; private set; }


        public sliderImageViewModel()
        {
            source = new List<sliderImage>();
            CreateMonkeyCollection();

        }

        void CreateMonkeyCollection()
        {
            source.Add(new sliderImage
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRdrTJykeSe4VZtgO_wdsX5Aya_e6HU7l_GzD2WAqYT8eufvKK3"
            });
            source.Add(new sliderImage
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQ7Ro5r_BfbpUOi8eOJVpeAxGhBeEfMmugCORqaDGWjXNrffzZW"
            });
            source.Add(new sliderImage
            {
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRmCbvlAg48fyryQgHdp66wWiRm4CClCVCzFPxFZpEmkUVSOhaJ"
            });
            sliderImage = new ObservableCollection<sliderImage>(source);
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
