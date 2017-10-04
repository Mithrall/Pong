using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pong {
    class Ball:INotifyPropertyChanged {
        private double _x;
        private double _y;
        private bool _movingRight;
        private int _leftResult;
        private int _rightResult;

        public double X {
            get { return _x; }
            set {
                _x = value;
                OnPropertyChanged();
            }
        }

        public double Y {
            get { return _y; }
            set {
                _y = value;
                OnPropertyChanged();
            }
        }

        public bool MovingRight {
            get { return _movingRight; }
            set {
                _movingRight = value;
                OnPropertyChanged();
            }
        }

        public int LeftResult {
            get { return _leftResult; }
            set {
                _leftResult = value;
                OnPropertyChanged();
            }
        }

        public int RightResult {
            get { return _rightResult; }
            set {
                _rightResult = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}