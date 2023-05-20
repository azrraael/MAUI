using MAUTest.MVVM.models;
using PropertyChanged;
using System.Windows.Input;

namespace MAUTest.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CalculatorViewModel
    {
        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int Result { get; set; }

        public int control { get; set; }

        public ICommand clean => new Command(() => { Number1 = 0; Number2 = 0; Result = 0; control = 0; });
        public ICommand AddCommand => new Command(() => Result = Number1 + Number2);

        public ICommand SubtracCommand => new Command(() => Result = Number1 - Number2);

        public ICommand MultiplierCommand => new Command(() => Result = Number1 * Number2);

        public ICommand DivideCommand => new Command(() => Result = Number1 / Number2);

        public ICommand Add1 => new Command(() => { if (control == 0){   Number1 = 1; control = 1; } else{ Number2 = 1; } });
        public ICommand Add2 => new Command(() => { if (control == 0) { Number1 = 2; control = 1; } else { Number2 = 2; } });

        public ICommand Add3 => new Command(() => { if (control == 0) { Number1 = 3; control = 1; } else { Number2 = 3; } });

        public ICommand Add4 => new Command(() => { if (control == 0) { Number1 = 4; control = 1; } else { Number2 = 4; } });

        public ICommand Add5 => new Command(() => { if (control == 0) { Number1 = 5; control = 1; } else { Number2 = 5; } });

        public ICommand Add6 => new Command(() => { if (control == 0) { Number1 = 6; control = 1; } else { Number2 = 6; } });

        public ICommand Add7 => new Command(() => { if (control == 0) { Number1 = 7; control = 1; } else { Number2 = 7; } });

        public ICommand Add8 => new Command(() => { if (control == 0) { Number1 = 8; control = 1; } else { Number2 = 8; } });

        public ICommand Add9 => new Command(() => { if (control == 0) { Number1 = 9; control = 1; } else { Number2 = 9; } });

        public ICommand Add0 => new Command(() => { if (control == 0) { Number1 = 0; control = 1; } else { Number2 = 0; } });
    }
}
