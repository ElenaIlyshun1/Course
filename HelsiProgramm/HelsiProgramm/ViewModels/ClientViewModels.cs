using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelsiProgramm.ViewModels
{
    public class ClientViewModels : INotifyPropertyChanged
    {
        int id;
        string name;
        string surename;
        string email;
        DateTime dataTime;
        //public string PathImg
        //{
        //    get { return this.img; }

        //    set
        //    {
        //        if (this.img != value)
        //        {
        //            this.img = value;
        //            this.NotifyPropertyChanged("PathImg");
        //        }
        //    }
        //}
        public int Id
        {
            get { return this.id; }

            set
            {
                if (this.id != value)
                {
                    this.id = value;
                    this.NotifyPropertyChanged("Id");
                }
            }
        }
        public string Name
        {
            get { return this.name; }

            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    this.NotifyPropertyChanged("Name");
                }
            }
        }

        public string Surename
        {
            get { return this.surename; }

            set
            {
                if (this.surename != value)
                {
                    this.surename = value;
                    this.NotifyPropertyChanged("Surename");
                }
            }
        }
        public string Email
        {
            get { return this.email; }

            set
            {
                if (this.email != value)
                {
                    this.email = value;
                    this.NotifyPropertyChanged("Email");
                }
            }
        }

        public DateTime Birth
        {
            get { return this.dataTime; }

            set
            {
                if (this.dataTime != value)
                {
                    this.dataTime = value;
                    this.NotifyPropertyChanged("Birth Day");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
