using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Pong {
    class Pad:INotifyPropertyChanged {
        private int _yPosition;

        public int YPosition {
            get { return _yPosition; }
            set {
                _yPosition = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}