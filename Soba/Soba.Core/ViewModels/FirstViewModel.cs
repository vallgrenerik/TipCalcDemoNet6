using MvvmCross.Core.ViewModels;
using System;
using System.Diagnostics;

namespace Soba.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel()
        {
        }

        private TimeSpan _time = DateTime.Now.TimeOfDay;

        public TimeSpan Time
        {
            get { return _time; }
            set
            {
                if (_time == value)
                    return;
                _time = value;
                RaisePropertyChanged(() => Time);
            }
        }

        private DateTime _date = DateTime.Now;

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (_date == value)
                    return;
                _date = value;
                RaisePropertyChanged(() => Date);
            }
        }

        private int _selected;

        public int Selected
        {
            get { return _selected; }
            set
            {
                if (_selected == value)
                    return;
                _selected = value;
                RaisePropertyChanged(() => Selected);
            }
        }

        public IMvxCommand GoCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    Debug.WriteLine("Go!");
                });
            }
        }

        private string _query;

        public string Query
        {
            get { return _query; }
            set
            {
                if (_query == value)
                    return;
                _query = value;
                RaisePropertyChanged(() => Query);
            }
        }

        private string _msg;

        public string Msg
        {
            get { return _msg; }
            set
            {
                if (_msg == value)
                    return;
                _msg = value;
                RaisePropertyChanged(() => Msg);
            }
        }

        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value == value)
                    return;
                _value = value;
                RaisePropertyChanged(() => Value);
            }
        }

        public bool IsHidden
        {
            get { return !_isOn; }
        }

        private bool _isOn;

        public bool IsOn
        {
            get { return _isOn; }
            set
            {
                if (_isOn == value)
                    return;
                _isOn = value;
                RaisePropertyChanged(() => IsOn);
                RaisePropertyChanged(() => IsHidden);
            }
        }
    }
}