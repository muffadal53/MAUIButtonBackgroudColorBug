using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUIButtonBackgroudColorBug.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool  changeButtonColor;

        public bool ChangeButtonColor
        {
            get => changeButtonColor;
            set
            {
                if (changeButtonColor != value)
                {
                    changeButtonColor = value;
                    OnPropertyChanged(); // reports this property
                }
            }
        }

        private Color _MyColor;

        public Color color
        {
            get { return _MyColor; }
            set { _MyColor = value; }
        }
        public MainPageViewModel()
        {
            color = Colors.Brown;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
