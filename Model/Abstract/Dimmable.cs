using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model.Abstract;

namespace Model.Concrete
{
    public abstract partial class Dimmable : Switchable, ISettable
    {    
        [ObservableProperty] private int _value;

        public int FeedBack { get; set; }
       
        [RelayCommand]
        public void SetValue(int value)
        {
            _value = value;
        }       
    }
}
