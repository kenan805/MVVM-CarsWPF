using MVVM_WPF_Task1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_WPF_Task1.Repository
{
    public class FakeRepo
    {
        public ObservableCollection<Car> Cars { get; set; }

        public FakeRepo()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Id=1,
                    Vendor="Bmw",
                    Model="M5",
                    Year=2020
                },
                new Car
                {
                    Id=2,
                    Vendor="Hyundai",
                    Model="i30 cw",
                    Year=2010
                },
                new Car
                {
                    Id=3,
                    Vendor="Mercedes",
                    Model="C200",
                    Year=2015
                },
                new Car
                {
                    Id=4,
                    Vendor="Kia",
                    Model="Sportage",
                    Year=2021
                },
                                                                                new Car
                {
                    Id=5,
                    Vendor="Lada",
                    Model="2107",
                    Year=2009
                }
            };
        }
    }
}
