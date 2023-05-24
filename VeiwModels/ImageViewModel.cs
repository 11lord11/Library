using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SerializationLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace MVVM.VeiwModels
{
    internal class ImageViewModel : INotifyPropertyChanged
    {
        public ImageViewModel()
        {
            OpenCom = new RelayCommand(OnOpen);
            
        }

        private void OnOpen()
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                
                using (var streamReader = new StreamReader(openFileDialog.FileName))
                {
                    UriImg = new Uri(openFileDialog.FileName);
                }
            }
        }

        private Uri uri;
        public ICommand OpenCom { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Uri UriImg
        {
            get => uri;
            set
            {
                uri = value;
                OnPropertyChanged();
            }
        }
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        
    }
}
